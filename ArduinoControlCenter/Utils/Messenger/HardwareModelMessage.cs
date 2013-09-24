using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Utils.Messenger
{
    class HardwareModelMessage : GenericTinyMessage<String>
    {
        public HardwareModelMessage(object sender, String content): base(sender, content)
        {
            this.Content = content;
        }
    }
}
