using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Class
{
    public partial class LoopStructureForm : Form
    {
        public LoopStructureForm()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Length == 0)
            {
                MessageBox.Show("textbox cannot be empty");
            }
            else
            {
                lstData.Items.Add(txtData.Text.ToString());
                txtData.Text = "";
                txtData.Focus();

            }
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int i = 0;
            double sum = 0;
            while (i<lstData.Items.Count)
            {
                sum = sum + Convert.ToDouble(lstData.Items[i]);
                i++;

            }

            lblSum.Text = sum.ToString();

            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            //diplaying even numbers

            int i = 8; 

            while (i < 99) 
            {
                if (i%2==0)
                {
                    lstData2.Items.Add(i);
                }
                i = i + 1; 
            }



           


        }

        private void btnDoWhileLoop_Click(object sender, EventArgs e)
        {
            int i = 0;
            double sum = 0;

            do
            {
                sum = sum + Convert.ToDouble(lstData.Items[i]);
                i++;

            } while (i < lstData.Items.Count);

            lblSum.Text = sum.ToString();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for (int i = 0; i < lstData.Items.Count; i++)
            {
                sum = sum + Convert.ToDouble(lstData.Items[i]);
            }

            lblSum.Text = sum.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
        }
    }
}
