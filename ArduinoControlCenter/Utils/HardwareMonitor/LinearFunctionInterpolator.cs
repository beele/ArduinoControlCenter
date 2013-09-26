using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoControlCenter.Utils.HardwareMonitor
{
    class LinearFunctionInterpolator
    {
        private List<LinearDataPoint> _dataPoints;

        public LinearFunctionInterpolator(List<LinearDataPoint> dataPoints)
        {
            _dataPoints = dataPoints;
        }

        public LinearDataPoint extrapolateSpeedFromTemperature(int temp)
        {
            LinearDataPoint point = new LinearDataPoint(temp, 0);

            LinearDataPoint lowerPoint = null;
            LinearDataPoint higherPoint = null;

            foreach (LinearDataPoint ldp in _dataPoints)
            {
                if(temp >= ldp.temperature) 
                {
                    if (lowerPoint != null)
                    {
                        if (lowerPoint.temperature < ldp.temperature)
                        {
                            lowerPoint = ldp;
                        }
                    }
                    else
                    {
                        lowerPoint = ldp;
                    }
                }
            }

            foreach (LinearDataPoint ldp in _dataPoints)
            {
                if (temp <= ldp.temperature)
                {
                    if (higherPoint != null)
                    {
                        if (higherPoint.temperature > ldp.temperature)
                        {
                            higherPoint = ldp;
                        }
                    }
                    else
                    {
                        higherPoint = ldp;
                    }
                }
            }

            //detect if the speed is exactly at one of the given datapoints
            if (higherPoint != null && lowerPoint != null &&
                higherPoint.temperature == lowerPoint.temperature)
            {
                point.temperature = higherPoint.temperature;
                point.speed = higherPoint.speed;
                return point;
            }
            else if(higherPoint == null && lowerPoint == null)
            {
                higherPoint = dataPoints[0];
                lowerPoint = dataPoints[1];
            }

            float mA = higherPoint.speed - lowerPoint.speed;
            float mB = higherPoint.temperature - lowerPoint.temperature;
            float m = mA / mB;

            float xFact = m * temp;
            float x1Fact = m * lowerPoint.temperature;
            float resultSpeed = xFact - x1Fact + lowerPoint.speed;
            point.speed = (int)resultSpeed;

            /*Console.WriteLine("mA = " + mA);
            Console.WriteLine("mB = " + mB);
            Console.WriteLine("m = " + m);
            Console.WriteLine("xFact = " + xFact);
            Console.WriteLine("x1Fact = " + x1Fact);
            Console.WriteLine("lowerpoint = " + lowerPoint.speed);
            Console.WriteLine("speed = " + resultSpeed);
            Console.WriteLine("---------------------------------------------------------");*/

            return point;
        }

        public LinearDataPoint extrapolateTemperatureFromSpeed(int speed)
        {
            throw new NotImplementedException();
        }

        public List<LinearDataPoint> dataPoints
        {
            get
            {
                return _dataPoints;
            }
            set
            {
                _dataPoints = value;
            }
        }
    }
}
