using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal interface IUser
    {
        void SendMessage(string userName, string message);
        void ReceiveMessage(string userName, string message);
        int Id { get; }
        string Name { get; }
        bool IsBusy { get; }
    }
}
