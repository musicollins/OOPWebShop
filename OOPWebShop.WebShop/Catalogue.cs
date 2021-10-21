using System.Collections.Generic;

namespace OOPWebShop.WebShop
{
    public class Catalogue
    {
        private static Dictionary<string, Product> ProductDictionary = new Dictionary<string, Product>()
        {
            { "iPhone 5", new Product("iPhone 5", 399, ProductType.PHYSICAL)},
            { "iPhone X", new Product("iPhone X", 999, ProductType.PHYSICAL)},
            { "iPhone 12 Pro", new Product("iPhone 12 Pro", 2000, ProductType.PHYSICAL)},
            { "MK11", new Product("MK11", 35, ProductType.DIGITAL)},
        };

        public static Product GetProduct(string productName)
        {
            if (ProductDictionary.ContainsKey(productName))
            {
                return ProductDictionary[productName];
            }
            else
            {
                return null;
            }
        }





    }
}
