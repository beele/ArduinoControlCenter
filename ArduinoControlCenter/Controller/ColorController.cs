
using System.Drawing;
using ArduinoControlCenter.Model;
using ArduinoControlCenter.Views;
using TinyMessenger;
using ArduinoControlCenter.Controller.Modes;

namespace ArduinoControlCenter.Controller
{
    public class ColorController
    {
        private MainForm gui;
        private ColorModel model;
        private TinyMessengerHub messageHub;

        public bool isDisposed;
        private ColorModel.COLORMODES _mode;

        private IColorMode activeMode;

        public ColorController(ColorModel model, TinyMessengerHub messageHub, MainForm gui)
        {
            this.model = model;
            this.messageHub = messageHub;
            this.gui = gui;
            this.isDisposed = false;
            this._mode = ColorModel.COLORMODES.manual;
        }

        //Data and model fields.
        public void setSelectedColor(Color color, bool saveToEeprom)
        {
            if (saveToEeprom)
            {
                model.saveNextColorToEeprom = true;
            }
            model.color = color;
        }

        public void setFadeStartColor(Color c)
        {
            model.startColor = c;
        }

        public void setFadeStopColor(Color c)
        {
            model.stopColor = c;
        }

        public void setEnhanceMode(bool doEnhance)
        {
            model.enhanceColor = doEnhance;
        }

        public void setSampleDelay(int delay)
        {
            model.delay = delay;
        }

        public void setFadeDuration(int duration)
        {
            model.duration = duration;
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
                            model.delay = gui.tbSmoothScreen.Value;
                            model.enhanceColor = true;
                            activeMode = new AverageColorMode(model);
                            activeMode.start();
                        break;
                        case ColorModel.COLORMODES.fade:
                            if (activeMode != null)
                            {
                                activeMode.stop();
                                activeMode = null;
                            }
                            activeMode = new FadeColorMode(model);
                            activeMode.start();
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
