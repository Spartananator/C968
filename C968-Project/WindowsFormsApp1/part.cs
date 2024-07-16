using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Part
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Inventory {  get; set; }
        public double Price { get; set; }
        public int Max {  get; set; }
        public int Min { get; set; }

        public Part(int id, string name, int inventory, double price, int max, int min) { 
            ID = id;
            Name= name;
            Inventory= inventory;
            Price= price;
            Max= max;
            Min= min;

        }
    }
}
