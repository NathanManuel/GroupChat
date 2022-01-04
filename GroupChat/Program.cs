using System;

namespace GroupChat
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatServer = new ChatServer();

            var john = new ChatUser("John", chatServer);
            var doe = new ChatUser("Doe", chatServer);
            var andrew = new ChatUser("Andrew", chatServer);
            var alex = new ChatUser("Alex", chatServer);
            var matei = new ChatUser("Matei", chatServer);
            var calin = new ChatUser("Calin", chatServer);
            var luca = new ChatUser("Luca", chatServer);
            var razvan = new ChatUser("Razvan", chatServer);
            var george = new ChatUser("George", chatServer);
            var david = new ChatObserver("David", chatServer);
            var nathan = new ChatObserver("Nathan", chatServer);

            chatServer.RegisterUser(nathan);
            chatServer.RegisterUser(john);
            chatServer.RegisterUser(doe);

            chatServer.RegisterUser(andrew);
            chatServer.RegisterUser(alex);
            chatServer.RegisterUser(matei);

            chatServer.Unregister(matei);

            chatServer.RegisterUser(calin);
            chatServer.RegisterUser(david);
            chatServer.RegisterUser(luca);
            chatServer.RegisterUser(razvan);
            chatServer.RegisterUser(george);


            john.SendMessage("Doe", "Test message");
            george.SendMessage("Alex", "Hello");

            Console.ReadLine();
        }
    }
}
