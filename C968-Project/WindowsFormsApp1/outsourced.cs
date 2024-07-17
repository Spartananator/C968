using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class outsourced : Part
    {
        public int companyName;


        public outsourced(int id, string name, int inventory, double price, int max, int min, int companyname) : base(id, name, inventory, price, max, min)
        {
            ID = id;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
            companyName = companyname;
        }

    }

}
