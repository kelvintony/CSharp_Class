using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Class.OOP_Class
{
    public partial class CircleCalcaluation : Form
    {
        public CircleCalcaluation()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            CircleClass.Circle_Class myObject = new CircleClass.Circle_Class();

            myObject.pie = double.Parse(txtPie.Text.ToString());
            myObject.angleOfCircle = double.Parse(txtAngle.Text.ToString());
            myObject.radius = double.Parse(txtRadius.Text.ToString());

            lblAreaOfCircle.Text = myObject.CalculateArea().ToString();
            lblAreaOfSector.Text = myObject.CalculateSector().ToString();
            lblCircumference.Text = myObject.CalculateCircumference().ToString();

            
        }
    }
}
