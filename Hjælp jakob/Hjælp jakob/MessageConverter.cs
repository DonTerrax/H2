using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_jakob
{
    public static class MessageConverter
    {
        public static string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }

        public static Message ConvertBodyToHTML(Message message)
        {
            message.Body = ConvertBodyToHTML(message.Body);
            return message;
        }
    }
}
