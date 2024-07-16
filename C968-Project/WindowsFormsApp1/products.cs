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
        public int ID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public double Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public BindingList<Part> AssociatedParts;

        public Product()
        {

        }
    }
}
