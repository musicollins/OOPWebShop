using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWebShop.WebShop
{
    public class ShoppingCart
    {
        //List<Product> Products = new List<Product>();
        //Dictionary<int, Product> Products = new Dictionary<int, Product>();
        List<Dictionary<int, Product>> Products = new List<Dictionary<int, Product>>();

        //public void AddProduct(Product product)
        //{
        //    Products.Add(product);
        //}

        public void addProduct(ProductAmount product)
        {
            Products.Add(product.getProduct());
        }

        //public void RemoveProduct(Guid productId)
        //{
        //    foreach (var product in Products)
        //    {
        //        if(product.Id == productId)
        //        {
        //            Products.Remove(product);
        //        }
        //    }
        //}
        public int GetTotalCost()
        {
            var totalCost = 0;
            foreach (var dictionary in Products)
            {
                totalCost += dictionary.Values.Sum(p => p.Price * dictionary.ElementAt(0).Key);
            }

            return totalCost;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var dictionaries in Products)
            {
                //sb.Append($"{product.Name}\n");
                foreach (var product in dictionaries)
                {
                    sb.Append($"{product.Value.Name}\n");
                }
                
            }

            var amount = 0;
            foreach (var dictionaries in Products)
            {
                foreach (var product in dictionaries)
                {
                    amount += product.Key;
                }
            }

            return $"Shopping Cart: \n" +
                $"Amount of Products: {amount}\n" +
                $"Total Cost: {GetTotalCost()}\n" +
                $"Product List: \n" +
                $"{sb}";
        }

    }
}
