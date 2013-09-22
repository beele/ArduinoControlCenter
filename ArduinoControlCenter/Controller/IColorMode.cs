using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoControlCenter.Controller
{
    interface IColorMode
    {
        bool isRunning
        {
            get;
            set;
        }

        void start();
        void stop();
    }
}
