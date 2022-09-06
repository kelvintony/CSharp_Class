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
    public partial class IFStatement : Form
    {
        public IFStatement()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = "yes \n" + 24.ToString();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string employeName = txtEmployeName.Text;
            double employeSalary = double.Parse(txtEmployeSalary.Text.ToString());

            double tax;
            double netIncome;

            if (lstLevel.SelectedIndex==0)

            {
               tax = 0.055 *employeSalary;
               netIncome = employeSalary - tax;
               lblResult.Text = "Name: " + employeName.ToString() + "\n" + "Tax: " + tax.ToString() + "\n" + "Net Income: " + netIncome.ToString();


            }
            else if (lstLevel.SelectedIndex == 1)
            {
                tax = 0.1 * employeSalary;
                netIncome = employeSalary - tax;
                lblResult.Text = "Name:" + employeName.ToString() + "\n" + "Tax: " + tax.ToString() + "\n" + "Net Income: " + netIncome.ToString();

            }
            else if (lstLevel.SelectedIndex == 2)
            {
                tax = 0.15 * employeSalary;
                netIncome = employeSalary - tax;
                lblResult.Text = "Name:" + employeName.ToString() + "\n" + "Tax: " + tax.ToString() + "\n" + "Net Income: " + netIncome.ToString();
            }


        }
    }
}
