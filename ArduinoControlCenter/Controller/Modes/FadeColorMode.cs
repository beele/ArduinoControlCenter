using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using ArduinoControlCenter.Model;

namespace ArduinoControlCenter.Controller.Modes
{
    class FadeColorMode : IColorMode
    {
        public bool isRunning { get; set; }

        private static Thread thread;

        private Color startColor;
        private Color endColor;

        private ColorModel model;

        public FadeColorMode(ColorModel model)
        {
            this.model = model;

            startColor = Color.White;
            endColor = Color.White;
        }

        public void start()
        {
            Console.WriteLine("Starting fade mode");

            isRunning = true;
            startColor = model.fadeStartColor;
            endColor = model.fadeStopColor;

            thread = new System.Threading.Thread(fade);
            thread.IsBackground = true;
            thread.Name = "fade color thread";
            thread.Start();
        }

        private void fade()
        {
            int steps = model.fadeDuration * 30; //Seconds times 30 for 30fps!

            int i = 0;
            while (isRunning && i < steps)
            {
                i++;
                float ratio = (float)i / (float)steps;
                int red = (int)(endColor.R * ratio + startColor.R * (1 - ratio));
                int green = (int)(endColor.G * ratio + startColor.G * (1 - ratio));
                int blue = (int)(endColor.B * ratio + startColor.B * (1 - ratio));
                model.color = Color.FromArgb(red, green, blue);

                Thread.Sleep(33);
            }
            //Reloop but now switch the colors!
            if (isRunning)
            {
                Color c = startColor;
                startColor = endColor;
                endColor = c;
                fade();
            }
        }

        public void stop()
        {
            Console.WriteLine("Stopping fade mode");
            isRunning = false;
        }
    }
}
