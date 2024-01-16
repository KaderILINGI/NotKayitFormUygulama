using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayit
{
    public partial class formogrnotkayitsistemi : Form
    {
        public formogrnotkayitsistemi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection(@"server=LAPTOP-7RVI861P\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDb;Integrated Security=True;");
        //Data Source=LAPTOP-7RVI861P\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDb;Integrated Security=True;Trust Server Certificate=True
        public string numara;
        private void formogrnotkayitsistemi_Load(object sender, EventArgs e)
        {
            lbl0000.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OgrNumara=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblnull.Text = dr[2].ToString() +""+ dr[3].ToString();
                lbls11.Text= dr[4].ToString();
                lbls22.Text= dr[5].ToString();
                lbls33.Text= dr[6].ToString();
                lblort1.Text= dr[7].ToString();
                lbldurumnull.Text= dr[8].ToString();
            }
        }
    }
}
