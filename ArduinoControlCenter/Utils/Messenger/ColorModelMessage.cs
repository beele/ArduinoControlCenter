using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyMessenger;

namespace ArduinoControlCenter.Utils.Messenger
{
    class ColorModelMessage : GenericTinyMessage<COLOR_FIELDS>
    {
        public ColorModelMessage(object sender, COLOR_FIELDS content): base(sender, content)
        {
            this.Content = content;
        }
    }

    class ColorControllerMessage : GenericTinyMessage<String>
    {
        public ColorControllerMessage(object sender, String content): base(sender, content)
        {
            this.Content = content;
        }
    }
}
