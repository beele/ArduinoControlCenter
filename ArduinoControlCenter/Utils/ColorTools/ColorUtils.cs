using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArduinoControlCenter.Utils.ColorUtils
{
    class ColorUtils
    {
        public Color lastColor;

        public ColorUtils()
        {
        }

        public Color processColor(int r, int g, int b)
        {
            //Values of 0 are not optimal, and could crash the app (div by zero!)
            r = r != 0 ? r : 1;
            g = g != 0 ? g : 1;
            b = b != 0 ? b : 1;

            float ratioR = r / 256.0f;
            float ratioG = g / 256.0f;
            float ratioB = b / 256.0f;
            float ratioTotal = ratioR + ratioG + ratioB;

            ratioR /= ratioTotal;
            ratioG /= ratioTotal;
            ratioB /= ratioTotal;

            //Dominant red
            if (r > (g + 10) && r > (b + 10))
            {
                r += (int)(r * ratioR * 3);
                g -= (int)(g * ratioG * 2);
                b -= (int)(b * ratioB * 2);
            }
            //Dominant green
            else if (g > (r + 10) && g > (b + 10))
            {
                r -= (int)(r * ratioR * 2);
                g += (int)(g * ratioG * 3);
                b -= (int)(b * ratioB * 2);
            }
            //Dominant blue
            else if (b > (g + 10) && b > (r + 10))
            {
                r -= (int)(r * ratioR * 2);
                g -= (int)(g * ratioG * 2);
                b += (int)(b * ratioB * 3);
            }
            else
            {
                r += (int)(r * ratioR * 3);
                g += (int)(g * ratioG * 3);
                b += (int)(b * ratioB * 3);
            }
            //Console.WriteLine("new color ==> R:" + r + " G:" + g + " B:" + b);

            //For safety, values that were amplified too much will be toned down again!
            r = r < 256 ? r : 255;
            g = g < 256 ? g : 255;
            b = b < 256 ? b : 255;
            lastColor = Color.FromArgb(r, g, b);

            return lastColor;
        }
    }
}
