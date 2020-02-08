using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_jakob
{
    class MessageSender:IMessageSender
    {
        public virtual void SendMessage( Message m, bool isHTML)
        {
                if (isHTML)
                    m.Body = MessageConverter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
        }


        public void SendMessageToAll(string[] to, Message m, bool isHTML)
        {
            
            
                if (isHTML)
                    m.Body = MessageConverter.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            
        }
    }
}
