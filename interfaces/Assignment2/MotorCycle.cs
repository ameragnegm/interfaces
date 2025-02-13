using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment2
{
    internal class MotorCycle : IVehicle
    {
        public void Descripe()
        {
            Console.WriteLine("My Motorcycle ");
        }

        public void Start()
        {
            Console.WriteLine("My Motorcycle started");
        }

        public void Stop()
        {
            Console.WriteLine("My Motorcycle stopped");
        }
    }
}
