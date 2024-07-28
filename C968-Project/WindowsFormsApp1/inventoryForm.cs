using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inventoryForm : Form
    {
        int idTracker = 0;
        public Inventory inventory = new Inventory();
         

        public inventoryForm()
        {
            
            InitializeComponent();
            partsGrid.DataSource = inventory.AllParts;
            productsGrid.DataSource = inventory.Products;



        }

        
        private void partsAdd_Click(object sender, EventArgs e)
        {
            openPartsForm(false, inventory, this);
        }

        private void partsModify_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.partsGrid.SelectedRows)
            {
                
                if (row.DataBoundItem.GetType() == typeof(inHouse))
                {
                    //MessageBox.Show("InHouse item detected!");
                    inHouse modify = row.DataBoundItem as inHouse;
                    openPartsForm(true, modify, inventory, this);
                }
                else if (row.DataBoundItem.GetType() == typeof(outSourced))
                {
                    //MessageBox.Show("outsourced item detected!");
                    outSourced modify = row.DataBoundItem as outSourced;
                    openPartsForm(true, modify, inventory, this);
                }
                else
                {
                    MessageBox.Show("There are no products to modify!");
                }
            }
            
        }
        private void openPartsForm(bool isModify, Inventory inventory, inventoryForm sender)
        { 
            partsForm form2 = new partsForm(idTracker, inventory, sender);
            
            form2.ShowDialog();

        }
        private void openPartsForm(bool isModify, outSourced modify, Inventory inventory, inventoryForm sender)
        {
            partsForm form2 = new partsForm(modify, inventory, sender);

            form2.ShowDialog();

        }
        private void openPartsForm(bool isModify, inHouse modify, Inventory inventory, inventoryForm sender)
        {
            partsForm form2 = new partsForm(modify, inventory, sender);

            form2.ShowDialog();

        }

        private void productAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            openProductForm(id, inventory, this);
        }

        private void productModify_Click(object sender, EventArgs e)
        {
            
            if (productsGrid.Rows.Count > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                Product modifyProduct = (row = this.productsGrid.CurrentRow).DataBoundItem as Product;
                openProductForm(modifyProduct, inventory, this);
            }
            else
            {
                MessageBox.Show("There are no products to modify!");
            }
            
        }

        private void openProductForm(int id, Inventory inventory, inventoryForm sender) 
        {
            productForm form3 = new productForm(id, inventory, sender);
            form3.ShowDialog();
        }
        private void openProductForm(Product productModify, Inventory inventory, inventoryForm sender)
        {
            
            productForm form3 = new productForm(productModify, inventory, sender);
            form3.ShowDialog();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string store = partSearchBox.Text;
                int id = int.Parse(store);
                Part foundpart = inventory.LookupPart(id);
                BindingList<Part> searchList = new BindingList<Part>();
                searchList.Add(foundpart);
                if (foundpart != null)
                {
                    partsGrid.DataSource = searchList;

                }
            } catch 
            {
                MessageBox.Show("Search Value must be numeric");
                partSearchBox.Text = "";
                partsGrid.DataSource = inventory.AllParts;
            }
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string store = productSearchBox.Text;
                int id = int.Parse(store);
                Product foundproduct = inventory.LookupProduct(id);
                BindingList<Product> searchList = new BindingList<Product>();
                searchList.Add(foundproduct);
                if (foundproduct != null)
                {
                    productsGrid.DataSource = searchList;

                }
            }
            catch
            {
                MessageBox.Show("Search Value must be numeric");
                productSearchBox.Text = "";
                productsGrid.DataSource = inventory.Products;
            }

        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            if(productSearchBox.Text == "")
            {
                productsGrid.DataSource = inventory.Products;
            }
            else
            {
                productSearchButton_Click(sender, e);
            }
        }

        private void partSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (partSearchBox.Text == "")
            {
                partsGrid.DataSource = inventory.AllParts;
            }
            else
            {
                partSearchButton_Click(sender, e);
            }
        }

        private void partsDelete_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirm Deletion", "Alert", buttons);
            DataGridViewRow row = new DataGridViewRow();
            Part partToRemove = (row = this.partsGrid.CurrentRow).DataBoundItem as Part;
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (Product prod in inventory.Products)
                    {
                        foreach (Part parts in prod.AssociatedParts)
                        {
                            if (parts.ID == partToRemove.ID)
                            {
                                
                                throw new Exception();
                            }
                            else
                            {
                                inventory.RemovePart(partToRemove.ID);
                            }
                        }
                    }


                    
                }
                catch 
                {
                    MessageBox.Show("Cannot be deleted, Part is associated with Product(s)");
                }
            }
        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirm Deletion", "Alert", buttons);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = new DataGridViewRow();
                Product productToRemove = (row = this.productsGrid.CurrentRow).DataBoundItem as Product;

                inventory.RemoveProduct(productToRemove.ProductID);
            }
        }
    }
}
