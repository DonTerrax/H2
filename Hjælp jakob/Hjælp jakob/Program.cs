using System;

namespace Hjælp_jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("Mike", "Nicklas", "Hello", "test", "test");
            message = MessageConverter.ConvertBodyToHTML(message);
            IMessageSender test = new VMessageSender();
            test.SendMessage(message,false);


        }
    }
}



