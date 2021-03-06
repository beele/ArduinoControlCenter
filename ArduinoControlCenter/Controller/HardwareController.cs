﻿using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.HardwareMonitor;
using ArduinoControlCenter.Utils.Messenger;
using ArduinoControlCenter.Views;
using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.WMI;
using System;
using System.Collections.Generic;
using System.Threading;
using TinyMessenger;

namespace ArduinoControlCenter.Controller
{
    public class HardwareController
    {
        private static Thread _thread;
        private MainForm _gui;

        private bool _isRunning;
        private HardwareModel _hardwareModel;
        private TinyMessengerHub _messageHub;

        private Computer _computer = new Computer();
        private List<ISensor> _sensors = new List<ISensor>();
        private IVisitor _visitor = new UpdateVisitor();
        private WmiProvider _provider;

        private LinearFunctionInterpolator _linearDataInterpolator;

        public HardwareController(HardwareModel _hardwareModel, TinyMessenger.TinyMessengerHub _messageHub, MainForm gui)
        {
            this._hardwareModel = _hardwareModel;
            this._messageHub = _messageHub;
            this._gui = gui;

            _isRunning = false;

            if (_hardwareModel.dataPoints == null)
            {
                List<LinearDataPoint> dataPoints = new List<LinearDataPoint>();
                dataPoints.Add(new LinearDataPoint(0, 0));
                dataPoints.Add(new LinearDataPoint(40, 0));
                dataPoints.Add(new LinearDataPoint(50, 35));
                dataPoints.Add(new LinearDataPoint(70, 70));
                dataPoints.Add(new LinearDataPoint(100, 100));
                _hardwareModel.dataPoints = dataPoints;
            }
            _linearDataInterpolator = new LinearFunctionInterpolator(_hardwareModel.dataPoints);
            

            _computer.CPUEnabled = true;
            //computer.FanControllerEnabled = true;
            _computer.GPUEnabled = true;
            //computer.HDDEnabled = true;
            //computer.MainboardEnabled = true;
            //computer.RAMEnabled = true;

            _computer.Open();
            _provider = new WmiProvider(_computer);   

            foreach (IHardware hw in _computer.Hardware)
            {
                Console.WriteLine(hw.Name);
                if (hw.HardwareType == HardwareType.CPU)
                {
                    foreach (ISensor sensor in hw.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && !sensor.Name.ToLower().Equals("cpu package"))
                        {
                            _sensors.Add(sensor);
                        }
                    }
                }
            }
            _hardwareModel.sensors = _sensors;

            _thread = new System.Threading.Thread(run);
            _thread.IsBackground = true;
            _thread.Name = "Hardware monitor thread";
            _thread.Start();
        }

        private void run()
        {
            _isRunning = true;
            while (_isRunning)
            {
                _computer.Accept(_visitor);
                _provider.Update();

                if(_sensors != null && _sensors.Count > 0)
                {
                    int calculatedTemp = 0;
                    int highestTemp = 0;
                    foreach (ISensor sensor in _sensors)
                    {
                        int sensorTemp = (int)sensor.Value;
                        calculatedTemp += (int)sensorTemp;
                        if (sensorTemp > highestTemp)
                        {
                            highestTemp = sensorTemp;
                        }
                    }
                    calculatedTemp = calculatedTemp / _sensors.Count;
                    _hardwareModel.calculatedCPUTemperature = calculatedTemp;
                    _hardwareModel.highestCoreTemp = highestTemp;

                    //TODO: paramterise temperature override for quiet mode! For now we override at 85°C!
                    if (_hardwareModel.quietModeEnabled && _hardwareModel.highestCoreTemp < 85)
                    {
                        _hardwareModel.calculatedSpeed = _hardwareModel.quietModeSpeed;
                    }
                    else if(_hardwareModel.highestCoreTemp < 85)
                    {
                        _hardwareModel.calculatedSpeed = _linearDataInterpolator.extrapolateSpeedFromTemperature(highestTemp).speed;
                    }
                    else
                    {
                        //When the temp is higher then the max safe override to 100% fan speed!
                        _hardwareModel.calculatedSpeed = 100;
                    }
                }
                else
                {
                    //If no sensors are found, set the calculated and highest temps to -1 and the fan speed to a static 70%
                    _hardwareModel.calculatedCPUTemperature = -1;
                    _hardwareModel.highestCoreTemp = -1;
                    _hardwareModel.quietModeEnabled = true;
                    _hardwareModel.calculatedSpeed = 70;
                }

                _messageHub.Publish(new HardwareModelMessage(this,"update"));
                Thread.Sleep(1000);
            }
        }
    }
}
