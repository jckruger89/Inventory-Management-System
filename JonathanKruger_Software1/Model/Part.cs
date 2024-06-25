using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonathanKruger_Software1
{
    public abstract class Part
    {
        //properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //Constructors
        public Part() { }
        public Part(string name, decimal price, int inStock, int min, int max)
        {
            PartID = AvailablePartID();
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        //Methods
        public int AvailablePartID()
        {
            int id = 1;
            foreach (Part p in Inventory.allParts)
            {
                if (p.PartID != id)
                    return id;
                else
                    id++;
            }
            return id;
        }

        //--------SAMPLE PARTS-------------------------------------
        public static void SampleParts()
        {
            Inventory.AddPart(new Inhouse("Wheel", 12.11m, 15, 5, 25, 1001));
            Inventory.AddPart(new Inhouse("Petal", 8.22m, 11, 5, 25, 1002));
            Inventory.AddPart(new Outsourced("Chain", 8.33m, 12, 5, 25, "Outdoor World"));
            Inventory.AddPart(new Outsourced("Seat", 4.55m, 8, 2, 15, "Cushion City"));
        }
    }
}
