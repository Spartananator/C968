using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inventoryForm : Form
    {
        BindingList<Part> allParts = new BindingList<Part>();
        
        public class inventory
        {
            public BindingList<Part> allParts;
            public BindingList<Product> allProducts;


        }
        public inventoryForm()
        {
            InitializeComponent();
            partsGrid.DataSource = allParts;




        }


        public void addPart(Part sentPart)
        {
            allParts.Add(sentPart);

        }



        private void partsAdd_Click(object sender, EventArgs e)
        {
            openPartsForm("Add Part");
        }

        private void partsModify_Click(object sender, EventArgs e)
        {
            int partID = 0;
            openPartsForm("Modify Part", partID);
        }
        private void openPartsForm(string type)
        { 
            partsForm form2 = new partsForm(this);
            form2.addModify.Text = type;
            form2.ShowDialog();

        }
        private void openPartsForm(string type, int partID)
        {
            partsForm form2 = new partsForm(this);
            form2.addModify.Text = type;
            form2.ShowDialog();

        }

        private void productAdd_Click(object sender, EventArgs e)
        {
            openProductForm("Add Product");
        }

        private void productModify_Click(object sender, EventArgs e)
        {
            int ID = 0;
            openProductForm("Modify Product", ID);
        }

        private void openProductForm(string type) 
        {
            productForm form3 = new productForm();
            form3.productFormType.Text = type;
            form3.ShowDialog();
        }
        private void openProductForm(string type, int ID)
        {
            productForm form3 = new productForm();
            form3.productFormType.Text = type;
            form3.ShowDialog();
        }
    }
}
