using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class inHouse : Part
    {

        public int machineID;


        public inHouse(int id, string name, int inventory, double price, int max, int min, int machineid) : base(id, name, inventory, price, max, min)
        {
            ID = id;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
            machineID = machineid;
        }
    }
}
