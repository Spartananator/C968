using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class outSourced : Part
    {
        public string companyName;


        public outSourced(int id, string name, decimal price, int instock, int max, int min, string companyname) : base(id, name, price, instock, max, min)
        {
            ID = id;
            Name = name;
            Price = price;
            InStock = instock;
            Max = max;
            Min = min;
            companyName = companyname;
        }

    }

}
