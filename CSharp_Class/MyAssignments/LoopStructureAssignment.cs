using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Class.MyAssignments
{
    public partial class LoopStructureAssignment : Form
    {
        public LoopStructureAssignment()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();

            int times = int.Parse(txtTimes.Text.ToString());
            int range = int.Parse(txtRange.Text.ToString());

            int i = 1;
            
            while (i <= range)
            {
                lstData.Items.Add(times + " X " + i + " = " + (times * i));
                i++;
            }
        }
    }
}
