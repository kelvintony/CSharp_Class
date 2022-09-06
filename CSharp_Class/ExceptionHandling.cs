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
    public partial class ExceptionHandling : Form
    {
        public ExceptionHandling()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = 0;
                double secondNumber = 0;
                double sum = 0;

                firstNumber = double.Parse(txtFirstNumber.Text.ToString());
                secondNumber = double.Parse(txtSecondNumber.Text.ToString());

                sum = firstNumber + secondNumber;

                lblResult.Text = sum.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("something bad happened..." + "\n" + ex.Message);
            }
            
        }
    }
}
