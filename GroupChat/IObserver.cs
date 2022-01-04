using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupChat
{
    internal interface IObserver
    {
        void ReceiveMessage(string userName, string message);
        int Id { get; }
        string Name { get; }
        bool IsBusy { get; }
    }
}
