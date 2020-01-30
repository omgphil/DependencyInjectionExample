using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public interface IPaymentProcessor
    {
        void ChargeCreditCard(string creditCardNumber, string expiryDate);
    }

    public class PaymentProcessor : IPaymentProcessor
    {
        public void ChargeCreditCard(string creditCardNumber, string expiryDate)
        {
            if (string.IsNullOrWhiteSpace(creditCardNumber))
            {
                throw new ArgumentException("Invalid Credit Card");
            }

            if (string.IsNullOrWhiteSpace(expiryDate))
            {
                throw new ArgumentException("Invalid Expiry Date");
            }

            Console.WriteLine("call to CC API");
        }
    }
}
