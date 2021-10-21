using System;

namespace OOPWebShop.WebShop
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ProductType { get; set; }

        public Product(string name, int price, string productType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            ProductType = productType;
        }

        public override string ToString()
        {
            return $"Product Type: { ProductType }, Product Name: {Name}, Product Price: {Price}";
        }
    }

    //public enum ProductType
    //{
    //    PHYSICAL, DIGITAL, UNDEFINED
    //}
}
