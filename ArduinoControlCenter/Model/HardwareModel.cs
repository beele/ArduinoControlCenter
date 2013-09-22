using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Model
{
    public class HardwareModel
    {
        private int _calculatedSpeed;
        private int _calculatedCPUTemperature;
        private int _highestCoreTemp;

        private TinyMessengerHub _messageHub;
        private List<ISensor> _sensors;

        public HardwareModel(TinyMessengerHub messageHub)
        {
            this._messageHub = messageHub;

            _calculatedCPUTemperature = -1;
            _calculatedSpeed = 100;
        }

        #region --== Properties ==--
        //PROPERTIES

        public List<ISensor> sensors 
        {
            get
            {
                return _sensors;
            }
            set
            {
                _sensors = value;
            }
        }

        public int calculatedSpeed 
        {
            get
            {
                return _calculatedSpeed;
            }
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
            get
            {
                return _calculatedCPUTemperature;
            }
            set
            {
                _calculatedCPUTemperature = value;
            }
        }

        public int highestCoreTemp
        {
            get
            {
                return _highestCoreTemp;
            }
            set
            {
                _highestCoreTemp = value;
            }
        }

        #endregion
    }
}
