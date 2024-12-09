using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class User
    {
        protected ChatMediator mediator;
        public string Name { get; private set; }
        public List<string> MessageHistory { get; private set; }

        public User(ChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.Name = name;
            this.MessageHistory = new List<string>();
        }

        public abstract void SendMessage(string message, string recipient);
        public abstract void ReceiveMessage(string message, string sender);
    }
}
