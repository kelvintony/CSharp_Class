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
    public partial class IfStatement : Form
    {
        public IfStatement()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double calculatedValue = 0;

            firstNumber = double.Parse(txtFirstNumber.Text.ToString());
            secondNumber= double.Parse(txtSecondNumber.Text.ToString());

            if (rbnAdd.Checked==true)
            {
                calculatedValue = firstNumber + secondNumber;
            }
            else if (rbnSubtract.Checked == true)
            {
                calculatedValue = firstNumber - secondNumber;
            }
            else if (rbnMultiply.Checked == true)
            {
                calculatedValue = firstNumber * secondNumber;
            }
            else if (rbnDivide.Checked == true)
            {
                calculatedValue = firstNumber / secondNumber;
            }

            lblResult.Text = calculatedValue.ToString();

        }
    }
}
