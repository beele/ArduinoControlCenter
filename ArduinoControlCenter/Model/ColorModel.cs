using System;
using System.Drawing;
using ArduinoControlCenter.Views;
using TinyMessenger;
using ArduinoControlCenter.Utils.Messenger;

namespace ArduinoControlCenter.Model
{
    public class ColorModel
    {
        public bool enhanceColor;
        public int delay;
        public int duration;

        public Color startColor;
        public Color stopColor;

        public enum COLORMODES { manual, screen, fade };

        private Color _color;
        private double _FPS;
        private String _status;
        private bool _saveNextColorToEeprom;

        private TinyMessengerHub _messageHub;

        public ColorModel(TinyMessengerHub messageHub)
        {
            this._messageHub = messageHub;

            duration = 1;
            _color = Color.White;
            _saveNextColorToEeprom = false;
        }

        #region --== Properties ==--
        //PROPERTIES

        public TinyMessengerHub messageHub { get { return _messageHub; } set { _messageHub = value; } }

        public Color color 
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                _messageHub.Publish(new ColorModelMessage(this,COLOR_FIELDS.COLOR));
            }
        }

        public double FPS 
        {
            get
            {
                return _FPS;
            }
            set
            {
                _FPS = value;
                _messageHub.Publish(new ColorModelMessage(this, COLOR_FIELDS.FPS));
            }
        }

        public String status 
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                _messageHub.Publish(new ColorModelMessage(this, COLOR_FIELDS.STATUS));
            }
        }

        public bool saveNextColorToEeprom
        {
            get
            {
                bool temp = _saveNextColorToEeprom;
                _saveNextColorToEeprom = false;
                return temp;
            }
            set
            {
                _saveNextColorToEeprom = value;
            }
        }

        #endregion
    }
}
