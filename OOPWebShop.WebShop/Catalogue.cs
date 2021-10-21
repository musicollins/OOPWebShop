using System.Collections.Generic;

namespace OOPWebShop.WebShop
{
    public class Catalogue
    {
        private static Dictionary<string, Product> ProductDictionary = new Dictionary<string, Product>()
        {
            { "iPhone 5", new Product("iPhone 5", 399, "Smartphones")},
            { "iPhone X", new Product("iPhone X", 999, "Smartphones")},
            { "iPhone 12 Pro", new Product("iPhone 12 Pro", 2000, "Smartphones")},
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
