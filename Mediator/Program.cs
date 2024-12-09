namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator();
            string name1 = "EGOR";
            string name2 = "VADIM";
            string name3 = "Artem";
            User user1 = new ChatUser(mediator, name1);
            User user2 = new ChatUser(mediator, name2);
            User user3 = new ChatUser(mediator, name3);

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.SendMessage("Привет, Vadim!", name2);
            user2.SendMessage("Привет, Artem! Как дела?", name3);
            user3.SendMessage("Привет привет!", name2);
            user3.SendMessage("Привет, EGOR!", name1);

            Console.WriteLine("\nИстория сообщений Egora:");
            foreach (var msg in user1.MessageHistory)
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("\nИстория сообщений Vadima:");
            foreach (var msg in user2.MessageHistory)
            {
                Console.WriteLine(msg);
            }

            mediator.RemoveUser(name3);

            user1.SendMessage("Пока, Artem!", name3); // Чарли уже вышел из чата.
        }
    }
}
