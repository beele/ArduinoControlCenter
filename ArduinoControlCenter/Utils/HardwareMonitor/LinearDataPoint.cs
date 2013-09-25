using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoControlCenter.Utils.HardwareMonitor
{
    public class LinearDataPoint
    {
        public int temperature;
        public int speed;

        public LinearDataPoint(int temp, int speed)
        {
            this.temperature = temp;
            this.speed = speed;
        }
    }
}
