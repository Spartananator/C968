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

        public partsForm()
        {
            InitializeComponent();
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
            
            this.Close();
        }
    }
}
