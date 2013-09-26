using ArduinoControlCenter.Utils.HardwareMonitor;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Model
{
    public class HardwareModel : ApplicationSettingsBase
    {
        private int _calculatedSpeed;
        private int _calculatedCPUTemperature;
        private int _highestCoreTemp;

        private bool _quietModeEnabled;
        private int _quietModeSpeed;

        private TinyMessengerHub _messageHub;
        private List<ISensor> _sensors;
        private List<LinearDataPoint> _dataPoints;

        public HardwareModel(TinyMessengerHub messageHub)
        {
            this._messageHub = messageHub;

            _calculatedCPUTemperature = -1;
            _calculatedSpeed = 100;
            _quietModeEnabled = false;
            _quietModeSpeed = 0;
        }

        #region --== Properties ==--
        //PROPERTIES
        public int calculatedSpeed 
        {
            get{return _calculatedSpeed;}
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Calculated speed is lower than 0, setting to 0");
                    _calculatedSpeed = 0;
                }
                else
                {
                    _calculatedSpeed = value;
                }
            }
        }

        public int calculatedCPUTemperature 
        {
            get{return _calculatedCPUTemperature;}
            set{_calculatedCPUTemperature = value;}
        }

        public int highestCoreTemp
        {
            get{return _highestCoreTemp;}
            set{_highestCoreTemp = value;}
        }

        public List<LinearDataPoint> dataPoints
        {
            get{return _dataPoints;}
            set { _dataPoints = value;}
        }

        public bool quietModeEnabled
        {
            get { return _quietModeEnabled; }
            set { _quietModeEnabled = value; }
        }

        public int quietModeSpeed
        {
            get { return _quietModeSpeed; }
            set { _quietModeSpeed = value; }
        }

        public TinyMessengerHub messageHub
        {
            get { return _messageHub; }
            set { _messageHub = value; }
        }

        public List<ISensor> sensors
        {
            get { return _sensors; }
            set { _sensors = value; }
        }

        #endregion
    }
}
