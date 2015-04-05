using System;
using System.Drawing;
using System.Drawing.Imaging;
using ArduinoControlCenter.Utils.ScreenCapture;
using ArduinoControlCenter.Model;
using System.Diagnostics;
using System.Windows.Forms;
/*using SlimDX.Direct3D9;
using SlimDX;*/

namespace ArduinoControlCenter.Utils.ColorTools
{
    class DirectXBitmapUtils //: IBitmapUtils
    {
        private ColorUtils cUtils;
        private Color averageColor;

        private ColorModel model;
        private Size size;

       /* private Device d;
        private Surface s;
        private DataRectangle dr;
        private DataStream gs;

        long[] totals;

        public DirectXBitmapUtils(ColorModel model) 
        {
            this.model = model;
            cUtils = new ColorUtils();

            size = Screen.PrimaryScreen.Bounds.Size;

            PresentParameters present_params = new PresentParameters();
            present_params.Windowed = true;
            present_params.SwapEffect = SwapEffect.Discard;

            d = new Device(new Direct3D(), 0, DeviceType.Hardware, IntPtr.Zero, CreateFlags.SoftwareVertexProcessing, present_params);
        }

        public Color getAverageScreenColor()
        {
            s = Surface.CreateOffscreenPlain(d, size.Width, size.Height, Format.A8R8G8B8, Pool.Scratch);
            d.GetFrontBufferData(0, s);

            dr = s.LockRectangle(LockFlags.None);
            gs = dr.Data;

            totals = new long[] { 0, 0, 0 };

            for (long pos = gs.Length; pos > 0; pos -= 8) 
            {
                byte[] bu = new byte[4];
                gs.Position = pos;
                gs.Read(bu, 0, 4);

                totals[2] += bu[2];
                totals[1] += bu[1];
                totals[0] += bu[0];
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

            //Cleanup
            s.Dispose();
            gs.Dispose();

            return averageColor;
        }

        public void dispose()
        {
            if(s != null) {
                s.Dispose();
            }
            if (gs != null)
            {
                gs.Dispose();
            }
            d.Dispose();
        }*/
    }
}
