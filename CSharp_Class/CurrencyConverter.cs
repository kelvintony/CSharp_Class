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
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text.ToString());

            double convertedValue=0;

            if (rbnInputNaira.Checked==true && rbnOutputNaira.Checked==true)
            {
                convertedValue = amount;
            }
            else if (rbnInputNaira.Checked == true && rbnOutputDollar.Checked == true)
            {
                convertedValue = amount /610;
            }

            lblOutput.Text = convertedValue.ToString();
        }
    }
}
