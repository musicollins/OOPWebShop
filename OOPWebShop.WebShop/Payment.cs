using System;

namespace OOPWebShop.WebShop
{
    public class Payment
    {
        public DateTime PaymentDate { get; }
        public int TotalCost { get; }
        public bool isPaid { get; }


        public Payment(int totalCost)
        {
            TotalCost = totalCost;
            PaymentDate = DateTime.Now;
            isPaid = true;
        }

        public override string ToString()
        {
            return $"Payment made: {PaymentDate.ToString("dddd, dd MMMM yyyy HH:mm:ss")}\n" +
                $"At a total cost of: {TotalCost}";
        }


    }

}
