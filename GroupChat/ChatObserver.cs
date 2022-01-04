using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal class ChatObserver:IObserver
    {
        private IChatServer _chatServer;

        public int Id { get; }
        public string Name { get; }
        public bool IsBusy { get; }

        public ChatObserver(string name, IChatServer chatServer)
        {
            Id = new Random().Next();
            Name = name;
            _chatServer = chatServer;
        }



        public void ReceiveMessage(string userName, string message)
        {
            Console.WriteLine($"Received message from {userName}: {message}");
        }

    }
}
