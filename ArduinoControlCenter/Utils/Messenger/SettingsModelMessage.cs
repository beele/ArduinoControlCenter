using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Utils.Messenger
{
    class SettingsModelMessage : GenericTinyMessage<String>
    {
        public SettingsModelMessage(object sender, String content): base(sender, content)
        {
            this.Content = content;
        }
    }
}
