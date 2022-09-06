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
    public partial class DatatypesAndVariables : Form
    {
        public DatatypesAndVariables()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtFirstNumber.Text.ToString());
            double y = double.Parse(txtSecondNumber.Text.ToString());


            double sum = x + y;

            lblResult.Text =sum.ToString();
        }

        private void btnGreetUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double age = double.Parse(txtAge.Text.ToString());

            if (age <= 19)
            {
                MessageBox.Show("you are still a teen you can't write jamb");
            }
            else if (age >= 20)
            {
                MessageBox.Show("you are a adult, you are eligible to write jamb");
            }

            string greetUser = "Good Morning " + firstName + " " + lastName + " how was your day";

            lblMessage.Text = greetUser.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

//iv. less than or equal to, <=
//v. equal to, ==
//vi. Not equal to, !=