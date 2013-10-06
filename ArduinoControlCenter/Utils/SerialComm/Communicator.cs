using System;
using System.Threading;
using System.IO.Ports;
using System.Drawing;
using ArduinoControlCenter.Model;

namespace ArduinoControlCenter.Utils.SerialComm
{
    class Communicator
    {
        private static Thread thread;
        private ColorModel _colorModel;
        private HardwareModel _hardwareModel;
        private SettingsModel _settingsModel;

        public bool isOpen;
        public Color prevColor;
        public int prevSpeed;

        private String commPort;
        private SerialPort port;

        public Communicator(ColorModel colorModel, HardwareModel hardwareModel, SettingsModel settingsModel)
        {
            this._colorModel = colorModel;
            this._hardwareModel = hardwareModel;
            this._settingsModel = settingsModel;
        }

        public void start(String commPort)
        {
            Console.WriteLine("Starting serial comm");

            this.prevColor = Color.Black;
            this.prevSpeed = -1;

            this.isOpen = true;
            this.commPort = commPort;

            thread = new System.Threading.Thread(openCommChannel);
            thread.IsBackground = true;
            thread.Name = "Arduino serial com thread";
            thread.Start();
        }

        public void stop()
        {
            if (isOpen)
            {
                Console.WriteLine("Stopping serial comm");

                sendStatusMessage("Not connected");
                isOpen = false;

                closeCommChannel();
            }
        }

        private void openCommChannel()
        {
            try
            {
                port = new SerialPort(commPort, 9600);
                port.DtrEnable = true;
                port.Open();
                Thread.Sleep(1200);
                sendStatusMessage("Arduino connected on " + commPort);
                communicate();
            }
            catch (Exception)
            {
                isOpen = false;
                closeCommChannel();
                sendStatusMessage("ERROR: Cannot open connection! Try restarting the app!");
            }
        }

        private void closeCommChannel()
        {
            if (port != null)
            {
                try
                {
                    port.Close();
                }
                catch (Exception)
                {
                    isOpen = false;
                    port = null;
                    sendStatusMessage("ERROR: Cannot close connecton! Try restarting the app!");
                }
            }
        }

        public void communicate()
        { 
            try
            {
                Color c;
                int speed;
                while (isOpen && port.IsOpen)
                {
                    c = _colorModel.color;
                    speed = _hardwareModel.calculatedSpeed;
                    if (c != prevColor || speed != prevSpeed)
                    {
                        int writeByte = _colorModel.saveNextColorToEeprom == true ? 0xee : 0xff;
                        Console.WriteLine("Sending data: R=" + c.R + "G=" + c.G + "B=" + c.B + " Fanspeed=" + speed);
                        port.Write(new byte[] { Convert.ToByte(writeByte) }, 0, 1);
                        port.Write(new byte[] { Convert.ToByte(c.R) }, 0, 1);
                        port.Write(new byte[] { Convert.ToByte(c.G) }, 0, 1);
                        port.Write(new byte[] { Convert.ToByte(c.B) }, 0, 1);
                        port.Write(new byte[] { Convert.ToByte(_hardwareModel.calculatedSpeed)},0 ,1);

                        //clear the buffers of otherwise the comm will fail at a given time.
                        port.DiscardInBuffer();
                        port.DiscardOutBuffer();

                        prevColor = c;
                        prevSpeed = speed;
                    }
                    Thread.Sleep(5);
                }
            }
            catch (Exception)
            {
                isOpen = false;
                closeCommChannel();
                sendStatusMessage("ERROR: Connection problems, try restarting the app!");
                if (_settingsModel.autoReconnect == true)
                {
                    start(commPort);
                }
            }
        }

        //Send a message back to the app!
        private void sendStatusMessage(String status)
        {
            _colorModel.status = status;
        }
    }
}
