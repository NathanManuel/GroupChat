using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal class ChatUser:IUser
    {
        private IChatServer _chatServer;

        public int Id { get; }
        public string Name { get; }
        public bool IsBusy { get; }

        public ChatUser(string name, IChatServer chatServer)
        {
            Id = new Random().Next();
            Name = name;
            _chatServer = chatServer;
        }


        public void SendMessage(string userName, string message)
        {
            _chatServer.SendMessage(Name, userName, message);
        }

        public void ReceiveMessage(string userName, string message)
        {
            Console.WriteLine($"Received message from {userName}: {message}");
        }


    }
}
