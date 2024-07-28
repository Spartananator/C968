using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class partsForm : Form
    {
        public inventoryForm inventoryform;
        public Inventory inv;
        public inHouse inhouse;
        public outSourced outsourced;
        private inHouse newInpart;
        private outSourced newOutpart;
        public bool ismodify = false;
        public partsForm(int idNum, Inventory inventory, inventoryForm inventoryForm)
        {
            InitializeComponent();
            inventoryform = inventoryForm;
            inv = inventory;
            InitializeNewPartID(idNum);

        }
        public partsForm(inHouse partModify, Inventory inventory, inventoryForm inventoryForm)
        {
            InitializeComponent();
            inhouse = partModify;
            CheckIsModify(inhouse);
            inventoryform = inventoryForm;
            inv = inventory;
            ismodify = true;
        }
        public partsForm(outSourced partModify, Inventory inventory, inventoryForm inventoryForm)
        {
            InitializeComponent();
            outsourced = partModify;
            CheckIsModify(outsourced);
            inventoryform = inventoryForm;
            inv = inventory;
            ismodify = true;
        }

        private bool isOutsourced = false;

        private void InitializeNewPartID(int idNum)
        {
            try
            {
                idBox.Text = inv.AllParts.Count.ToString();
            }
            catch
            {
                idBox.Text = "0";
            }
        }
        private void CheckIsModify(inHouse inhouse) 
        {
            idBox.Text = inhouse.ID.ToString();
            nameBox.Text = inhouse.Name.ToString();
            costBox.Text = inhouse.Price.ToString();
            inventoryBox.Text = inhouse.InStock.ToString();
            maxBox.Text = inhouse.Max.ToString();
            minBox.Text = inhouse.Min.ToString();
            sourceBox.Text = inhouse.machineID.ToString();
        }

        private void CheckIsModify(outSourced outsourced)
        {
            idBox.Text = outsourced.ID.ToString();
            nameBox.Text = outsourced.Name.ToString();
            costBox.Text = outsourced.Price.ToString();
            inventoryBox.Text = outsourced.InStock.ToString();
            maxBox.Text = outsourced.Max.ToString();
            minBox.Text = outsourced.Min.ToString();
            sourceBox.Text = outsourced.companyName.ToString();
            radioButton2.Checked = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                companyID.Location = new Point(43, 394);
                companyID.Text = "Machine ID";
                isOutsourced = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) 
            {
                companyID.Location =  new Point(10, 394);
                companyID.Text = "Company Name";
                isOutsourced = true;
            }
        }
        
        

        public void savePart_Click(object sender, EventArgs e)
        {
            try 
            {   

                int id = int.Parse(idBox.Text);
                string name = nameBox.Text;
                decimal price = decimal.Parse(costBox.Text);
                int instock = int.Parse(inventoryBox.Text);
                int max = int.Parse(maxBox.Text);
                int min = int.Parse(minBox.Text);
                bool maxWrong = false;
                bool minWrong = false;
                bool maxMinWrong = false;
                try
                {
                    maxWrong = (max < instock);
                    minWrong = (instock < min);
                    maxMinWrong = (max < min);
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
                    if (isOutsourced == true)
                    {
                        string companyName = sourceBox.Text;
                        newOutpart = new outSourced(id, name, price, instock, max, min, companyName);
                        inv.UpdatePart(id, newOutpart);
                    }
                    else
                    {
                        int machineID = int.Parse(sourceBox.Text);
                        newInpart = new inHouse(id, name, price, instock, max, min, machineID);
                        inv.UpdatePart(id, newInpart);
                    }
                }
                else
                {
                    if (isOutsourced == true)
                    {
                        string companyName = sourceBox.Text;
                        newOutpart = new outSourced(id, name, price, instock, max, min, companyName);
                        inv.AddPart(newOutpart);
                    }
                    else
                    {
                        int machineID = int.Parse(sourceBox.Text);
                        newInpart = new inHouse(id, name, price, instock, max, min, machineID);
                        inv.AddPart(newInpart);
                    }
                }
                this.Close();
            } catch
            {
                MessageBox.Show("Please verify all inputs.");
            }  
        }

        private void cancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
