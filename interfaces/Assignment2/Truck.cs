using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment2
{
    internal class Truck : IVehicle
    {
        public void Descripe()
        {
            Console.WriteLine("My Truck ");
        }

     

        public void Start()
        {
            Console.WriteLine("My Truck started");
        }

        public void Stop()
        {
            Console.WriteLine("My Truck stopped");
        }
    }
}
