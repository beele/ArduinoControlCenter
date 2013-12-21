using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Model
{
    public class SettingsModel
    {
        private TinyMessengerHub _messageHub;

        private bool _startOnBoot;
        private bool _autoReconnect;
        private bool _startMinimized;

        public SettingsModel(TinyMessengerHub messageHub)
        {
            _messageHub = messageHub;
        }

        #region --== properties ==--
        public TinyMessengerHub messageHub
        {
            get { return _messageHub; }
            set { _messageHub = value; }
        }

        public bool startOnBoot
        {
            get { return _startOnBoot; }
            set { _startOnBoot = value; }
        }

        public bool autoReconnect
        {
            get { return _autoReconnect; }
            set { _autoReconnect = value; }
        }

        public bool startMinimized
        {
            get { return _startMinimized; }
            set { _startMinimized = value; }
        }
        #endregion
    }
}
