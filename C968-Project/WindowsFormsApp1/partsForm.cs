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
    public partial class partsForm : Form
    {
        private inventoryForm inventoryFormInstance;

        public partsForm(inventoryForm shitfuck)
        {
            InitializeComponent();
            this.inventoryFormInstance = shitfuck;
        }

        private void radioPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                companyID.Location = new Point(43, 394);
                companyID.Text = "Machine ID";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) 
            {
                companyID.Location =  new Point(10, 394);
                companyID.Text = "Company Name";
            }
        }

        public void savePart_Click(object sender, EventArgs e)
        {
            Part newPart = new Part(0, "tire", 4, 12.11, 5, 1);
            inventoryFormInstance.addPart(newPart);
            this.Close();
        }
    }
}
