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
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public Part(int id, string name, decimal price, int instock,  int min, int max) { 
            ID = id;
            Name= name;
            Price= price;
            InStock = instock;
            Min = min;
            Max = max;
            

        }
    }
}
