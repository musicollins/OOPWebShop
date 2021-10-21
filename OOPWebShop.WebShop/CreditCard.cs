using System;

namespace OOPWebShop.WebShop
{
    public class CreditCard
    {
        public readonly long CreditCardNum;

        public CreditCard(long accNum)
        {
            CreditCardNum = accNum;
        }
        public Payment MakePayment(int totalcost)
        {
            //validation
            return new Payment(totalcost);

        }
        public override string ToString()
        {
            return $"Credit Card Number: {CreditCardNum}";
        }




    }
}