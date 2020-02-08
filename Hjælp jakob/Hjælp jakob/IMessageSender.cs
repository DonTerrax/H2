

namespace Hjælp_jakob
{
    
    public interface IMessageSender
    {

        void SendMessage(Message m, bool isHTML);

        void SendMessageToAll(string[] to, Message m, bool isHTML);

    }
}
