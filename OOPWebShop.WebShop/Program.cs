using System;

namespace OOPWebShop.WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("John", "Smith", 111122223334444);
            
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(Catalogue.GetProduct("iPhone 5"));
            cart.AddProduct(Catalogue.GetProduct("iPhone 12 Pro"));


            var order = cust.PlaceOrder(cart);
            Console.WriteLine(order.ReviewOrder());
            var receipt = order.OrderPayment(cust.PayForOrder(cart));
            Console.WriteLine(receipt);
            






        }
    }
}
