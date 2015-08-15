using ArduinoControlCenter.Model;
using System;
using System.Drawing;
using System.Threading;

namespace ArduinoControlCenter.Controller.Modes
{
    class TemperarureColorMode : IColorMode
    {
        public bool isRunning { get; set; }

        private static Thread thread;

        private Color coolColor;
        private Color hotColor;

        private int coolThreshold;
        private int hotThreshold;

        private ColorModel model;
        private HardwareModel hwModel;

        public TemperarureColorMode(ColorModel model, HardwareModel hwModel)
        {
            this.model = model;
            this.hwModel = hwModel;

            coolColor = model.coldTempColor;
            hotColor = model.hotTempColor;

            coolThreshold = model.coldTemp;
            hotThreshold = model.hotTemp;
        }

        public void start()
        {
            Console.WriteLine("Starting temperature mode");
            isRunning = true;

            thread = new System.Threading.Thread(calculateColorForTemp);
            thread.IsBackground = true;
            thread.Name = "temperature color thread";
            thread.Start();
        }

        private void calculateColorForTemp()
        {
            int steps = hotThreshold - coolThreshold;
            int temp = hwModel.highestCoreTemp;

            temp = temp < coolThreshold ? coolThreshold : temp;
            temp = temp > hotThreshold ? hotThreshold : temp;
            int offset = temp - coolThreshold;

            while (isRunning)
            {
                float ratio = (float)offset / (float)steps;
                int red = (int)(hotColor.R * ratio + coolColor.R * (1 - ratio));
                int green = (int)(hotColor.G * ratio + coolColor.G * (1 - ratio));
                int blue = (int)(hotColor.B * ratio + coolColor.B * (1 - ratio));
                model.color = Color.FromArgb(red, green, blue);

                Thread.Sleep(33);
            }
        }

        public void stop()
        {
            Console.WriteLine("Stopping temperature mode");
            isRunning = false;
        }
    }
}
