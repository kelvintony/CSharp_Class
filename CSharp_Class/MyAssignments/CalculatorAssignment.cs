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
    public partial class CalculatorAssignment : Form
    {
        public CalculatorAssignment()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text.ToString());
            double secondNumber = double.Parse(txtSecondNumber.Text.ToString());

            double calculatedValue;

            if (lstPerformOperation.SelectedIndex == 0)
            {
                calculatedValue = firstNumber + secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 1)
            {
                calculatedValue = firstNumber * secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 2)
            {
                calculatedValue = firstNumber - secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 3)
            {
                calculatedValue = firstNumber / secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text.ToString());
            double secondNumber = double.Parse(txtSecondNumber.Text.ToString());

            double calculatedValue;

            if (rbnAdd.Checked == true)
            {
                calculatedValue = firstNumber + secondNumber;
                lblResult2.Text = calculatedValue.ToString();
            }
            else if (rbnSubtract.Checked == true)
            {
                calculatedValue = firstNumber - secondNumber;
                lblResult2.Text = calculatedValue.ToString();
            }
            else if (rbnMultiply.Checked == true)
            {
                calculatedValue = firstNumber * secondNumber;
                lblResult2.Text = calculatedValue.ToString();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstPerformOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(txtFirstNumber.Text.ToString());
            double secondNumber = double.Parse(txtSecondNumber.Text.ToString());

            double calculatedValue;

            if (lstPerformOperation.SelectedIndex == 0)
            {
                calculatedValue = firstNumber + secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 1)
            {
                calculatedValue = firstNumber * secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 2)
            {
                calculatedValue = firstNumber - secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
            else if (lstPerformOperation.SelectedIndex == 3)
            {
                calculatedValue = firstNumber / secondNumber;
                lblResult.Text = calculatedValue.ToString();
            }
        }

        private void CalculatorAssignment_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
