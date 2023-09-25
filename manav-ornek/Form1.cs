using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manav_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(txtMeyve.Text);
            txtMeyve.Text = "";

        }

        private void txtMeyve_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Clear();
        }

        private void btnSecilenleriSil_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Remove(lstSepet.SelectedItem);
        }
    }
}
