using System.Collections.Generic;

namespace OOPWebShop.WebShop
{
    public class ProductAmount
    {
        Dictionary<int, Product> productAmount = new();

        public ProductAmount(Product product, int amount = 1)
        {
            productAmount.Add(amount, product);
        }
        public Dictionary<int, Product> getProduct()
        {
            return productAmount;
        }
    }
}
