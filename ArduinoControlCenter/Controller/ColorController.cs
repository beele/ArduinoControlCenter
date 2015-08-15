
using System.Drawing;
using ArduinoControlCenter.Model;
using ArduinoControlCenter.Views;
using TinyMessenger;
using ArduinoControlCenter.Controller.Modes;
using ArduinoControlCenter.Utils.Messenger;

namespace ArduinoControlCenter.Controller
{
    public class ColorController
    {
        private MainForm _gui;
        private TinyMessengerHub _messageHub;

        public bool isDisposed;

        private ColorModel _colorModel;
        private HardwareModel _hwModel;

        private ColorModel.COLORMODES _mode;
        private IColorMode activeMode;

        public ColorController(ColorModel model, HardwareModel hwModel, TinyMessengerHub messageHub, MainForm gui)
        {
            this._colorModel = model;
            this._hwModel = hwModel;
            this._messageHub = messageHub;
            this._gui = gui;
            this.isDisposed = false;
        }

        public void autoStartMode()
        {
            this._mode = ColorModel.COLORMODES.manual;
            _messageHub.Publish(new ColorModelMessage(this, COLOR_FIELDS.COLOR));
        }

        //Data and model fields.
        public void setSelectedColor(Color color, bool saveToEeprom)
        {
            if (saveToEeprom)
            {
                _colorModel.saveNextColorToEeprom = true;
            }
            _colorModel.color = color;
        }

        public ColorModel.COLORMODES mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
                if (_mode == ColorModel.COLORMODES.manual)
                {
                    if (activeMode.isRunning)
                    {
                        activeMode.stop();
                    }
                }
                else
                {
                    switch (_mode)
                    {
                        case ColorModel.COLORMODES.screen:
                            if (activeMode != null)
                            {
                                activeMode.stop();
                                activeMode = null;
                            }
                            _colorModel.delay = _gui.tbSmoothScreen.Value;
                            _colorModel.doEnhancementOfColor = true;
                            activeMode = new AverageColorMode(_colorModel);
                            activeMode.start();
                            break;
                        case ColorModel.COLORMODES.fade:
                            if (activeMode != null)
                            {
                                activeMode.stop();
                                activeMode = null;
                            }
                            activeMode = new FadeColorMode(_colorModel);
                            activeMode.start();
                            break;
                        case ColorModel.COLORMODES.temp:
                            if (activeMode != null)
                            {
                                activeMode.stop();
                                activeMode = null;
                            }
                            activeMode = new TemperarureColorMode(_colorModel, _hwModel);
                            activeMode.start();
                            break;
                    }
                }
            }
        }

        public void dispose()
        {
            if (activeMode != null)
            {
                activeMode.stop();
            }
            isDisposed = true;
        }
    }
}
