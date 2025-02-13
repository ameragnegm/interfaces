using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment2
{
    internal class Car : IVehicle
    {
        public void Descripe()
        {
            Console.WriteLine("My car ");
        }

        public void Start()
        {
            Console.WriteLine("My car started");
        }

        public void Stop()
        {
            Console.WriteLine("My  car stopped");
        }
    }
}
