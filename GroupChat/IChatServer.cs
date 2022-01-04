using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal interface IChatServer
    {
        void RegisterUser(IUser user);
        void Unregister(IUser user);
        void RegisterUser(IObserver observer);
        void Unregister(IObserver observer);
        void SendMessage(string senderName, string receiverName, string message);
    }
}
