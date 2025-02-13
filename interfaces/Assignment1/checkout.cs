using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment1
{
    internal class Checkout
    {
        IPayment ChoosePaymentMethod(string method)
        {
            switch (method)
            {
                case "PayPal":
                    return new PayPal();
                case "BankTransfer":
                    return new BankTransfer();
                case "CreditCard":
                    return new CreditCardPayment();
                default:
                    throw new ArgumentException("Invalid payment type");
            }
        }

        public void PaymentInfo(string method, double amount)
        {
            IPayment payment = ChoosePaymentMethod(method);
            payment.PaymentProcess(amount);

        }
    }
}
