﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment1
{
    internal class CreditCardPayment : IPayment
    {
        public void PaymentProcess(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Payment amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("CreditCard");
            }
        }
    }
}
