using System;
using System.Drawing;

namespace ArduinoControlCenter.Utils.ScreenCapture
{
    class CaptureScreen
    {
        //This structure shall be used to keep the size of the screen.
        public struct SIZE
        {
            public int cx;
            public int cy;
        }

        public static Bitmap CaptureDesktop()
        {
            SIZE size;
            IntPtr hBitmap;
            IntPtr hDC = Win32Wrapper.GetDC(Win32Wrapper.GetDesktopWindow());
            IntPtr hMemDC = GDIWrapper.CreateCompatibleDC(hDC);

            size.cx = Win32Wrapper.GetSystemMetrics
                      (Win32Wrapper.SM_CXSCREEN);

            size.cy = Win32Wrapper.GetSystemMetrics
                      (Win32Wrapper.SM_CYSCREEN);

            hBitmap = GDIWrapper.CreateCompatibleBitmap(hDC, size.cx, size.cy);

            if (hBitmap != IntPtr.Zero)
            {
                IntPtr hOld = (IntPtr)GDIWrapper.SelectObject
                                       (hMemDC, hBitmap);

                GDIWrapper.BitBlt(hMemDC, 0, 0, size.cx , size.cy, hDC,
                                               0, 0, GDIWrapper.SRCCOPY);

                GDIWrapper.SelectObject(hMemDC, hOld);
                GDIWrapper.DeleteDC(hMemDC);
                Win32Wrapper.ReleaseDC(Win32Wrapper.GetDesktopWindow(), hDC);
                Bitmap bmp = System.Drawing.Image.FromHbitmap(hBitmap);
                GDIWrapper.DeleteObject(hBitmap);
                GC.Collect();
                return bmp;
            }
            return null;
        }
    }
}
