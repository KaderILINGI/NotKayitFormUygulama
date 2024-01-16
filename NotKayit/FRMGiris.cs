using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotKayit
{
    public partial class FRMGiris : Form
    {
        public FRMGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formogrnotkayitsistemi frm= new formogrnotkayitsistemi();
            frm.numara = maskedTextBox1.Text;
            frm.Show();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FRMOgretmenDetay fr= new FRMOgretmenDetay();
                fr.Show();
            }
        }
    }
}
