using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment4
{
    internal class Email :INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($" Sending Via  Email ({message})");
        }
    }
}
