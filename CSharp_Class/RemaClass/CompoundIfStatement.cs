using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Class.RemaClass
{
    public partial class CompoundIfStatement : Form
    {
        public CompoundIfStatement()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click_1(object sender, EventArgs e)
        {
            string name = "";
            double salary = 0;
            double tax = 0;

            salary = double.Parse(txtSalary.Text.ToString());
            name = txtName.Text;

            tax = 7 * salary / 100;

            lblOutput.Text = "Hi " + name + "\n"+ "Basic Salary: "+ '\u20A6'+ salary  + "\n" + "Tax: " + tax;
        }
    }
}
