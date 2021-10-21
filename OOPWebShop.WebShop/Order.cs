using System;
using System.Text;

namespace OOPWebShop.WebShop
{
    public class Order
    {
        public Guid orderId { get; }
        public Customer Customer { get; }
        public ShoppingCart ShoppingCart { get; }
        public Payment Payment { get; set; }
        public Order(Customer customer, ShoppingCart shoppingCart)
        {
            orderId = Guid.NewGuid();
            Customer = customer;
            ShoppingCart = shoppingCart;
        }
        public string ReviewOrder()
        {
            return $"Order ID: {orderId}\n" +
                $"Customer: {Customer.FullName}\n" +
                $"Ordered the following products: \n" +
                $"{ShoppingCart.ToString()}";
        }
        public Receipt OrderPayment(Payment payment)
        {
            Payment = payment;
            if (payment.isPaid)
            {
                return new Receipt($"OrderId: {orderId}" +
                    $"Order Paid: Date: {Payment.ToString()}\n" +
                    $"Dear {Customer.FullName}, thank you for your purchase. Here comes your receipt\n" +
                    $"Paid with CreditCard {Customer.CreditCard.CreditCardNum}\n" +
                    $"Ordered following products\n" +
                    $"{ShoppingCart.ToString()}");
            }
            else
            {
                return null;
            }
           
        }
    }
}
