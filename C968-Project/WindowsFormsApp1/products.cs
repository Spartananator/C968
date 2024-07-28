using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        

        public Product(int id, string name, decimal price, int inventory, int max, int min)
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
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].ID == id)
                {
                    Part part = AssociatedParts[i];
                    AssociatedParts.Remove(part);
                    return true;
                }
                
            }
            return false;
        }

        public Part LookupAssociatedPart(int id )
        {

                foreach (Part p in AssociatedParts)
                {
                    if (p.ID == id)
                    {
                         Part holder = p;
                        return holder;
                    }

                }
                
                return null;
            
        }
    }
}
