using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatMediator
    {
        private readonly Dictionary<string, User> users = new Dictionary<string, User>();

        // Добавление пользователя в чат
        public void AddUser(User user)
        {
            if (!users.ContainsKey(user.Name))
            {
                users[user.Name] = user;
                Console.WriteLine($"{user.Name} присоединился к чату.");
            }
            else
            {
                Console.WriteLine($"Пользователь с именем {user.Name} уже существует.");
            }
        }

        // Удаление пользователя из чата
        public void RemoveUser(string name)
        {
            if (users.ContainsKey(name))
            {
                users.Remove(name);
                Console.WriteLine($"{name} покинул чат.");
            }
            else
            {
                Console.WriteLine($"Пользователя с именем {name} не существует.");
            }
        }

        // Отправка сообщения от одного пользователя другому
        public void SendMessage(string message, string recipient, User sender)
        {
            if (users.ContainsKey(recipient))
            {
                users[recipient].ReceiveMessage(message, sender.Name);
            }
            else
            {
                Console.WriteLine($"Получатель {recipient} не найден в чате.");
            }
        }
    }
}
