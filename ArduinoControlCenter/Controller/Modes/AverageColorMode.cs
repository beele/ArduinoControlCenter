using System;
using System.Diagnostics;
using System.Threading;
using ArduinoControlCenter.Model;
using ArduinoControlCenter.Utils.ColorUtils;

namespace ArduinoControlCenter.Controller.Modes
{
    class AverageColorMode : IColorMode
    {
        public bool isRunning { get; set; }

        private static Thread thread;
        private bool enhanceColor;

        private ColorModel model;

        public AverageColorMode(ColorModel model)
        {
            this.model = model;
        }

        public void start()
        {
            Console.WriteLine("Starting average color finder");

            enhanceColor = model.enhanceColor;
            isRunning = true;
            
            thread = new System.Threading.Thread(getAverage);
            thread.IsBackground = true;
            thread.Name = "average color thread";
            thread.Start();
        }

        private void getAverage()
        {
            BitmapUtils bitmapper = new BitmapUtils(model);
            Stopwatch watch = new Stopwatch();

            long prevTime = 0;

            while (isRunning)
            {
                watch.Start();

                model.color = bitmapper.getAverageScreenColor(); ;
                Thread.Sleep(model.delay);

                long time = watch.ElapsedMilliseconds - prevTime;
                prevTime = watch.ElapsedMilliseconds;
                model.FPS = 1000 / time;
            }

            bitmapper.dispose();
            bitmapper = null;
            watch.Stop();
            watch = null;
        }

        public void stop()
        {
            Console.WriteLine("Stopping average color finder");
            isRunning = false;
        }
    }
}
