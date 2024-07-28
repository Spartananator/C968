using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Inventory
    {
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }






        public bool RemoveProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);

                    return true;
                }

            }
            return false;
        }






        public Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            return null;
        }






        public void UpdateProduct(int id, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == id)
                {
                    Products[i] = product;
                }
            }
        }
    }
}
