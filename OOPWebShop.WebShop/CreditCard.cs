namespace OOPWebShop.WebShop
{
    public class CreditCard
    {
        public readonly long CreditCardNum;

        public CreditCard(long accNum)
        {
            CreditCardNum = accNum;
        }

        public override string ToString()
        {
            return $"Credit Card Number: {CreditCardNum}";
        }

    }
}