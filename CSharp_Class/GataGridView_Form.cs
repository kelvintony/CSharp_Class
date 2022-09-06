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
    public partial class DataGridView_Form : Form
    {
        public DataGridView_Form()
        {
            InitializeComponent();
        }

        private void btnSubmitData_Click(object sender, EventArgs e)
        {
            int i = dgvData.Rows.Count;
            dgvData.Rows.Add(1);

            dgvData.Rows[i - 1].Cells[0].Value = i.ToString();
            dgvData.Rows[i - 1].Cells[1].Value = txtSurname.Text.ToString();
            dgvData.Rows[i - 1].Cells[2].Value = txtFirstName.Text.ToString();
            dgvData.Rows[i - 1].Cells[3].Value = txtAge.Text.ToString();
            dgvData.Rows[i - 1].Cells[4].Value = cboSex.SelectedItem.ToString();

            txtSurname.Text = "";
            txtFirstName.Text = "";
            txtAge.Text = "";

            txtSurname.Focus();



        }
    }
}
