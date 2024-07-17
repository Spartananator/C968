using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public class Inventory
    {
        public BindingList<Part> AllParts;
        public BindingList<Product> Products;

        public void AddProduct(Product product)
        {

        }
        public bool RemoveProduct(int productID)
        {
            return true;
        }
        public Product LookupProduct(int productID)
        {
            
        }
        public void UpdateProduct(int productID, Product product)
        {

        }
        public void AddPart(Part part)
        {

        }
        public bool RemovePart(int partID)
        {
            return true;
        }
        public Part LookupPart(int partID)
        {

        }
        public void UpdatePart(int partID, Part part)
        {

        }

    }
}
