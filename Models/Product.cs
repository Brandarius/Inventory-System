using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2.Models
{
    public class Product
    {
        // Unique identifier for the product
        public int ProductID { get; set; }

        // Name of the product
        public string ProductName { get; set; }

        // Price of the product
        public decimal Price { get; set; }

        // Current products in stock
        public int Instock { get; set; }

        // Minimum and maximum allowed stock levels
        public int Min { get; set; }
        public int Max { get; set; }



        // Constructor for the Product class
        public Product(int productID, string productName, decimal price, int instock, int min, int max)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Instock = instock;
            Min = min;
            Max = max;
        }

        // Returns a string representation of the product
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

    }
}
