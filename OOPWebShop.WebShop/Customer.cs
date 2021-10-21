using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWebShop.WebShop
{
    public class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName  => Firstname + " " + Lastname;
        public CreditCard CreditCard { get; set; }

        public Customer(string firstname, string lastname, long CCNum)
        {
            Firstname = firstname;
            Lastname = lastname;
            CreditCard = new CreditCard(CCNum);
        }

        //Create Order
        public Order PlaceOrder(ShoppingCart cart)
        {
            var currentCustomer = this;
            var order = new Order(currentCustomer, cart);
            return order;
        }
        //Handle Pay

        public Payment PayForOrder(ShoppingCart cart)
        {
            return CreditCard.MakePayment(cart.GetTotalCost());
        }

        public override string ToString()
        {
            return $"Customer name: {FullName}. Creditcard number: {CreditCard.CreditCardNum}";
        }
    }
}
