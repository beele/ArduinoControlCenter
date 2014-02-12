using System;
using System.Drawing;
using System.Drawing.Imaging;
using ArduinoControlCenter.Utils.ScreenCapture;
using ArduinoControlCenter.Model;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArduinoControlCenter.Utils.ColorTools
{
    class BitmapUtils : IBitmapUtils
    {
        private ColorUtils cUtils;
        private Color averageColor;

        private ColorModel model;
        private Size size;

        private Bitmap bmp;
        private BitmapData srcData;
        private Graphics graphics;
        long[] totals;

        public BitmapUtils(ColorModel model)
        {
            this.model = model;
            cUtils = new ColorUtils();

            size = Screen.PrimaryScreen.Bounds.Size;
            bmp = new Bitmap(size.Width, size.Height);
            graphics = Graphics.FromImage(bmp);
        }

        public Color getAverageScreenColor()
        {
            //Load bitmap!
            graphics.CopyFromScreen(0, 0, 0, 0, size);
            //Bitmap bmp = CaptureScreen.CaptureDesktop();
            srcData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                                ImageLockMode.ReadOnly,
                                                PixelFormat.Format32bppArgb);
            int stride = srcData.Stride;
            IntPtr Scan0 = srcData.Scan0;

            totals = new long[] { 0, 0, 0 };

            //Process all the pixels in the bitmap
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = size.Height - 1; y >= 0; y -= 2)
                {
                    for (int x = size.Width - 1; x >= 0; x -= 2)
                    {
                        for (int color = 2; color >= 0; color--)
                        {
                            int idx = (y * stride) + x * 4 + color;

                            totals[color] += p[idx];
                        }
                    }
                }
            }

            float ratio = (size.Width * size.Height) / 2.0f;

            //Calculate RGB values
            int r = (int)(totals[2] / ratio);
            int g = (int)(totals[1] / ratio);
            int b = (int)(totals[0] / ratio);
            //Console.WriteLine("Original color ==> R:" + r + " G:" + g + " B:" + b);

            //Modify the color if needed
            if (model.enhanceColor)
            {
                averageColor = cUtils.processColor(r, g, b);
            }
            else
            {
                averageColor = Color.FromArgb(r, g, b);
            }

            //Clean up the mess that was made!
            bmp.UnlockBits(srcData);
            GC.Collect();
           
            return averageColor;
        }

        public void dispose()
        {
            bmp = null;
            graphics = null;
            srcData = null;
            cUtils = null;
            GC.Collect();
        }
    }
}
