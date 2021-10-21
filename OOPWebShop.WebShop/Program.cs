using System;

namespace OOPWebShop.WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("John", "Smith", 111122223334444);
            
            ShoppingCart cart = new ShoppingCart();
            cart.addProduct(new ProductAmount(Catalogue.GetProduct("iPhone 5"),2));
            cart.addProduct(new ProductAmount(Catalogue.GetProduct("iPhone X")));
            cart.addProduct(new ProductAmount(Catalogue.GetProduct("iPhone 12 Pro"),3));
            cart.addProduct(new ProductAmount(Catalogue.GetProduct("iPhone 5"),3));


            var order = cust.PlaceOrder(cart);
            Console.WriteLine(order.ReviewOrder());
            var receipt = order.OrderPayment(cust.PayForOrder(cart));
            Console.WriteLine("RECEIPT => \n" + receipt.getReceipt());
            






        }
    }
}
