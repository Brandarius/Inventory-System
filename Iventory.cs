using Inventory2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2
{
    /// Static class responsible for managing the application's inventory of parts and products.
    // Provides CRUD operations and ID assignment logic.
    public static class Inventory
    {
        // Lists holding all parts and products
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static BindingSource PartSource { get; } = new BindingSource
        {
            DataSource = Parts
        };

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingSource ProductSource { get; } = new BindingSource
        {
            DataSource = Products
        };


        // Part Management Methods

        // Adds a new part to the inventory.
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        // Removes a part from the inventory.
        public static void DeletePart(Part part)
        {
            Parts.Remove(part);
        }


        // Updates an existing part in the list by index.
        public static void UpdatePart(Part part)
        {
            var index = Parts.IndexOf(part);
            if (index >= 0)
            {
                Parts[index] = part;
            }
        }


        // Product Management Methods
       
        /// Adds a new product to the inventory.
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Updates an existing product in the list based on ProductID match.
        public static void UpdateProduct(Product updatedProduct)
        {
            var existingProduct = Products.FirstOrDefault(p => p.ProductID == updatedProduct.ProductID);
            if (existingProduct != null)
            {
                int index = Products.IndexOf(existingProduct);
                Products[index] = updatedProduct;
            }
        }


        // Removes a product from the inventory.
        public static void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        // ID Generation Helper Functions

        // Returns the next available ProductID (lowest unused positive integer).
        // Useful for auto-assigning unique IDs.
        public static int GetNextAvailableProductID()
        {
            int id = 1;
            var existingIDs = Products.Select(p => p.ProductID).ToHashSet();
            while (existingIDs.Contains(id))
            {
                id++;
            }
            return id;
        }

        // Returns the next available PartID (lowest unused positive integer).
        public static int GetNextAvailablePartID()
        {
            int id = 1;
            var existingIDs = Parts.Select(p => p.PartID).ToHashSet();
            while (existingIDs.Contains(id))
            {
                id++;
            }
            return id;
        }
    }
}
