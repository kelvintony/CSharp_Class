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
    public partial class ListBoxControl : Form
    {
        public ListBoxControl()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(txtData.Text.Length==0)
            {
                MessageBox.Show("textbox cannot be empty");
            }
            else
            {
                lstData.Items.Add(txtData.Text.ToString());
                txtData.Text = "";
                txtData.Focus();
            
            }
            
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            int indexNumber = lstData.SelectedIndex;
            MessageBox.Show(indexNumber.ToString());
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
            string item = lstData.SelectedItem.ToString();
            MessageBox.Show(item);
        }

        private void btnItemCount_Click(object sender, EventArgs e)
        {
            int countItems = lstData.Items.Count;
            MessageBox.Show(countItems.ToString());
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to remove item from the list box", "Confirm delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string item = lstData.SelectedItem.ToString();
                lstData.Items.Remove(item);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear the list box","Confirm delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                lstData.Items.Clear();
            }
        }

        private void txtData_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
