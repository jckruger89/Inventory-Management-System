using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace JonathanKruger_Software1
{
    public class Product
    {
        //Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> associatedParts { get; set; }

        //--------SAMPLE PRODUCTS-------------------------------------

        public static void SampleProducts()
        {
            Inventory.products.Add(new Product(1, "Red Bicycle", 150.99m, 25, 10, 50));
            Inventory.products.Add(new Product(2, "Yellow Bicycle", 180.99m, 15, 5, 50));
            Inventory.products.Add(new Product(3, "Blue Bicycle", 205.99m, 30, 25, 80));
        }

        // Constructors
        public Product()
        {
            associatedParts = new BindingList<Part>();
        }
        public Product(string name, decimal price, int inStock, int min, int max)
        {
            ProductID = AvailableProductID();
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            associatedParts = new BindingList<Part>();
        }
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            associatedParts = new BindingList<Part>();
        }

        // Methods
        public static int AvailableProductID()
        {
            int id = 1;
            bool productIDExists = true;
            while (productIDExists)
            {
                id++;
                productIDExists = Inventory.products.Any(Product => Product.ProductID == id);
            }
            return id;
        }

        public static void AddAssociatedPart(Part part)
        {    
            AddProduct.partsNeeded.Add(part);
        }
      
        public static bool RemoveAssociatedPart(int partID)
        {
            bool removed = false;

            foreach (Part part in AddProduct.partsNeeded)
            {
                if (part.PartID == partID)
                { 
                    AddProduct.partsNeeded.Remove(part);
                    return removed = true;
                }
                else
                {
                    removed = false;
                }
            }
            return removed;
        }
        public Part LookupAssociatedPart(int ID)
        {
            foreach (Part P in associatedParts)
            {
                if (P.PartID == ID)
                {
                    return P;
                }
            }
            return null;
        }
    }
}
