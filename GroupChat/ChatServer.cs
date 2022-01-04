using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal class ChatServer:IChatServer
    {
        private List<IUser> _users = new List<IUser>();
        private List<IObserver> _observers = new List<IObserver>();

        public void RegisterUser(IUser user)
        {
            //register user and notify each user that a new one joined the club
            if (_users.Count < 10-_observers.Count)
            {
                if (!_users.Contains(user))
                {
                    _users.Add(user);
                    user.ReceiveMessage("Console", $"User {user.Name} is online");
                }
            }
            else
            {
                user.ReceiveMessage("Console", $"User {user.Name} cant join");
            }

        }

        public void Unregister(IUser user)
        {
            //unregister user and notify each user that one leaved the club
            if (_users.Contains(user))
            {
                _users.Remove(user);
                user.ReceiveMessage("Console", $"User {user.Name} is offline");
            }
        }

         public void RegisterUser(IObserver observer)
        {
            //register user and notify each user that a new one joined the club
            if (_observers.Count<2)
            {
                if (!_observers.Contains(observer))
                {
                    _observers.Add(observer);
                    observer.ReceiveMessage("Console", $"Observer {observer.Name} is online");
                }
            }
            else
            {
                observer.ReceiveMessage("Console", $"Observer {observer.Name} cant join");
            }

        }

        public void Unregister(IObserver observer)
        {
            //unregister user and notify each user that one leaved the club
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                observer.ReceiveMessage("Console", $"Observer {observer.Name} is offline");
            }
        }

        public void SendMessage(string senderName, string receiverName, string message)
        {
            //send message to specific user
            var receiver = _users.FirstOrDefault(x => x.Name.Equals(receiverName));
            receiver.ReceiveMessage(senderName, message);
        }
    }
}
