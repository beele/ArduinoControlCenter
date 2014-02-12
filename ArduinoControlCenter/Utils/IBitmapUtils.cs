using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ArduinoControlCenter.Utils
{
    public interface IBitmapUtils
    {
        Color getAverageScreenColor();

        void dispose();
    }
}
