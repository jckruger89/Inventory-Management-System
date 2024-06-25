using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonathanKruger_Software1
{
    public class Inventory
    {
        //Fields
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> allParts = new BindingList<Part>();

        public Product Product { get; set; }
        public Part Part { get; set; }

        //Methods
        public static void AddProduct(Product product)
        {
           products.Add(product);        
        }

        public static bool RemoveProduct(int id)
        {
            bool executed = false;
            foreach (Product prod in products.ToList())
            {
                if (prod.ProductID == id)
                {
                    products.Remove(prod);
                    executed = true;
                }
            }
            return executed;          
        }

        public static Product LookupProduct(int productID)
        {    
            foreach (Product p in products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;
        }

        public static void AddPart(Part part)
        {
            allParts.Add(part);
        }

        public static bool DeletePart(Part selection)
        {
            allParts.Remove(selection);
            return true;
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part p in allParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public static void UpdatePart(int id, Part part)
        {
            foreach (Part p in allParts.ToList())
            {
                if (p.PartID == id)
                {
                    DeletePart(p);
                    AddPart(part);
                }
            }
        }

        public static void UpdateProduct(int id, Product product)
        {
            foreach (Product prod in products.ToList())
            {
                if (prod.ProductID == id)
                {
                    RemoveProduct(id);
                    AddProduct(product);
                }
            }
        }
    }
}
