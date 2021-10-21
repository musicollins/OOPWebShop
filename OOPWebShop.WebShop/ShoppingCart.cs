using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWebShop.WebShop
{
    public class ShoppingCart
    {
        List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(Guid productId)
        {
            foreach (var product in Products)
            {
                if(product.Id == productId)
                {
                    Products.Remove(product);
                }
            }
        }
        public int GetTotalCost()
        {
            var totalCost = 0;
            foreach (var product in Products)
            {
                totalCost = totalCost + product.Price;
            }

            return totalCost;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var product in Products)
            {
                sb.Append($"{product.Name}\n");
            }

            return $"Shopping Cart: \n" +
                $"Amount of Products: {Products.Count}\n" +
                $"Total Cost: {GetTotalCost()}\n" +
                $"Product List: \n" +
                $"{sb}";
        }

    }
}
