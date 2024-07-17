using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Product
    {
        public BindingList<Part> AssociatedParts;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        

        public Product(int id, string name, decimal price, int inventory, int min, int max)
        {
            ProductID = id;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min; Max = max;


        }
        public void AssociatePart(Part newPart) 
        {

            AssociatedParts.Add(newPart);

        }

        public bool DeassociatePart(int id)
        {
            return false;
        }

        public Part LookupAssociatedPart(int id )
        {

        }
    }
}
