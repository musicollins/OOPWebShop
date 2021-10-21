using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWebShop.WebShop
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName  => Firstname + " " + Lastname;
        public string Email { get; set; }
        public string Address { get; set; }
        public CreditCard CreditCard { get; set; }

        public Customer(string firstname, string lastname, long CCNum)
        {
            Firstname = firstname;
            Lastname = lastname;
            CreditCard = new CreditCard(CCNum);

        }

        public override string ToString()
        {
            return $"Customer name: {FullName}. Creditcard number: {CreditCard.CreditCardNum}";
        }
    }
}
