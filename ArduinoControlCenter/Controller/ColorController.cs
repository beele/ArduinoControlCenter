
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
        private ColorModel _colorModel;
        private TinyMessengerHub _messageHub;

        public bool isDisposed;
        private ColorModel.COLORMODES _mode;

        private IColorMode activeMode;

        public ColorController(ColorModel model, TinyMessengerHub messageHub, MainForm gui)
        {
            this._colorModel = model;
            this._messageHub = messageHub;
            this._gui = gui;
            this.isDisposed = false;
        }

        public void autoStartMode()
        {
            this._mode = ColorModel.COLORMODES.manual;
            //TODO: this message should contain the active mode, so the view can be updated accordingly!
            _messageHub.Publish(new ColorControllerMessage(this, "update"));
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

        public void setFadeStartColor(Color c)
        {
            _colorModel.startColor = c;
        }

        public void setFadeStopColor(Color c)
        {
            _colorModel.stopColor = c;
        }

        public void setEnhanceMode(bool doEnhance)
        {
            _colorModel.enhanceColor = doEnhance;
        }

        public void setSampleDelay(int delay)
        {
            _colorModel.delay = delay;
        }

        public void setFadeDuration(int duration)
        {
            _colorModel.duration = duration;
        }

        public void dispose()
        {
            if (activeMode != null)
            {
                activeMode.stop();
            }
            isDisposed = true;
        }

        #region --== Properties ==--
        //PROPERTIES

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
                            if (activeMode!= null)
                            {
                                activeMode.stop();
                                activeMode = null;
                            }
                            _colorModel.delay = _gui.tbSmoothScreen.Value;
                            _colorModel.enhanceColor = true;
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
                    }
                }
            }
        }
        #endregion
    }
}
