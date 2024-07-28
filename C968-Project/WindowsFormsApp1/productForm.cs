using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class productForm : Form

        
    {
        public inventoryForm inventoryform;
        public Inventory inv;
        private Product newproduct = new Product(0, null, 0, 0, 0, 0);
        private BindingList<Part> partList = new BindingList<Part>();

        public bool ismodify = false;
        public productForm(int idNum, Inventory inventory, inventoryForm inventoryForm)
        {
            InitializeComponent();
            inv = inventory;
            inventoryform = inventoryForm;
            InitializeNewProductID(idNum);
            initializeLists();
            partsAvailableGrid.DataSource = partList;
            partsInProduct.DataSource = newproduct.AssociatedParts;
        }
        public productForm(Product productModify, Inventory inventory, inventoryForm inventoryForm)
        {
            InitializeComponent();
            
            inventoryform = inventoryForm;
            inv = inventory;
            newproduct = productModify;

            CheckIsModify(newproduct);            
            productFormType.Text = "Modify Part";

            initializeLists();
            partsInProduct.DataSource = newproduct.AssociatedParts;
            partsAvailableGrid.DataSource = partList;
            ismodify = true;
        }




        private void initializeLists()
        {
            
            foreach (Part part in inv.AllParts) 
            {
                bool partInProduct = false;
                for (int i = 0; i < newproduct.AssociatedParts.Count; i++) 
                { 
                    if (part.ID == newproduct.AssociatedParts[i].ID)
                    {
                        partInProduct = true;
                        newproduct.AssociatedParts[i] = part;
                        
                    }
                }
                if (partInProduct == false)
                {
                    partList.Add(part);
                }

            }
        }

        private void InitializeNewProductID(int idNum)
        {
            try
            {
                idBox.Text = inv.Products.Count.ToString();
            }
            catch
            {
                idBox.Text = "0";
            }
        }
        private void CheckIsModify(Product newproduct)
        {
            try
            {
                idBox.Text = newproduct.ProductID.ToString();
                nameBox.Text = newproduct.Name.ToString();
                costBox.Text = newproduct.Price.ToString();
                inventoryBox.Text = newproduct.Inventory.ToString();
                maxBox.Text = newproduct.Max.ToString();
                minBox.Text = newproduct.Min.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured", ex.ToString());
            }
        }
        
        private bool add;
        private void partRemoveProduct_Click(object sender, EventArgs e)
        {
            add = false;
            swapParts(add);
        }

        private void partAddProduct_Click(object sender, EventArgs e)
        {
            add = true;
            swapParts(add);
        }

        private void swapParts(bool add)
        {
            
            
            if (add)
            {
                if (partsAvailableGrid.Rows.Count > 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    Part partToAdd = (row = this.partsAvailableGrid.CurrentRow).DataBoundItem as Part;
                    newproduct.AssociatePart(partToAdd);
                    partList.Remove(partToAdd);
                }
                else
                {
                    MessageBox.Show("No Parts to move!");
                }
            }
            else
            {
                if (partsInProduct.Rows.Count > 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    Part partToAdd = (row = this.partsInProduct.CurrentRow).DataBoundItem as Part;
                    partList.Add(partToAdd);
                    int id = partToAdd.ID;
                    newproduct.DeassociatePart(id);
                }
                else
                {
                    MessageBox.Show("No Parts to move!");
                }
            }            
        }

        private void confirmProduct_Click(object sender, EventArgs e)
        {
            try
            {

                newproduct.ProductID = int.Parse(idBox.Text);
                newproduct.Name = nameBox.Text;
                newproduct.Price = decimal.Parse(costBox.Text);
                newproduct.Inventory = int.Parse(inventoryBox.Text);
                newproduct.Max = int.Parse(maxBox.Text);
                newproduct.Min = int.Parse(minBox.Text);
                bool maxWrong = false;
                bool minWrong = false;
                bool maxMinWrong = false;
                try
                {
                    maxWrong = (newproduct.Max < newproduct.Inventory);
                    minWrong = (newproduct.Inventory < newproduct.Min);
                    maxMinWrong = (newproduct.Max < newproduct.Min);
                    if (maxWrong != false | minWrong != false | maxMinWrong != false)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Inventory value is higher than Max Inventory: " + maxWrong.ToString() + "\nInventory value is lower than Minimum Inventory: " + minWrong.ToString() + "\nMax value is smaller than the minimum value: " + maxMinWrong.ToString());
                    throw new Exception();
                }


                if (ismodify == true)
                {
                    try
                    {
                        inv.UpdateProduct(newproduct.ProductID, newproduct);
                        this.Close();

                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                            
                            inv.AddProduct(newproduct);
                            this.Close();
                    }
                    catch 
                    { 
                    
                    }
                }



                
            }
            catch 
            {
                MessageBox.Show("Please veryify all values are correct");
            }
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchProductPartsBox_TextChanged(object sender, EventArgs e)
        {
            if (searchProductPartsBox.Text == "")
            {
                partsInProduct.DataSource = newproduct.AssociatedParts;
            }
            else
            {
                searchAction();
            }
        }
        private void searchAction()
        {
            try
            {
                string store = searchProductPartsBox.Text;
                int id = int.Parse(store);
                Part foundpart = newproduct.LookupAssociatedPart(id);
                BindingList<Part> searchList = new BindingList<Part>();
                try
                {
                    if (foundpart != null)
                    {
                        searchList.Add(foundpart);
                        partsInProduct.DataSource = searchList;

                    }
                }
                catch
                {
                    MessageBox.Show("No Search Results");
                }
            }
            catch
            {
                MessageBox.Show("Search Value must be numeric");
                searchProductPartsBox.Text = "";
                partsInProduct.DataSource = newproduct.AssociatedParts;
            }
        }
    }
}
