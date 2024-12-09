using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mediator
{
    class ChatUser : User
    {
        public ChatUser(ChatMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message, string recipient)
        {
            Console.WriteLine($"{Name} отправляет сообщение '{message}' для {recipient}");
            mediator.SendMessage(message, recipient, this);
        }

        public override void ReceiveMessage(string message, string sender)
        {
            Console.WriteLine($"{Name} получает сообщение от {sender}: {message}");
            MessageHistory.Add($"От {sender}: {message}");
        }
    }
}
