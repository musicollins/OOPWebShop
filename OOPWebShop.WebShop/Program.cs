using System;

namespace OOPWebShop.WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("John", "Smith", 111122223334444);
            Console.WriteLine(cust.ToString());

            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(Catalogue.GetProduct("iPhone 5"));
            cart.AddProduct(Catalogue.GetProduct("iPhone 12 Pro"));

            Console.WriteLine(cart.ToString()); ;





        }
    }
}
