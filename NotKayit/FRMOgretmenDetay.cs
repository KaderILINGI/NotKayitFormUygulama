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
    public partial class FRMOgretmenDetay : Form
    {
        public FRMOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-7RVI861P\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDb;Integrated Security=True;");

        private void FRMOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciNotKayıtDbDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.ogrenciNotKayıtDbDataSet.TBLDERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS(OgrNumara,OgrAdi,OgrSoyad) values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", Textnumara.Text);
            komut.Parameters.AddWithValue("@p2" , textAd.Text);
            komut.Parameters.AddWithValue("@p3" , textSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBLDERSTableAdapter.Fill(this.ogrenciNotKayıtDbDataSet.TBLDERS);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Textnumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1= Convert.ToDouble(textS1.Text);
            s2= Convert.ToDouble(textS2.Text);
            s3= Convert.ToDouble(textS3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrt.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OgrS1=@p1, OgrS2=@p2, OgrS3=@p3, Ortalama=@p4, Durum=@p5 where OgrNumara=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", textS1.Text);
            komut.Parameters.AddWithValue("@p2", textS2.Text);
            komut.Parameters.AddWithValue("@p3", textS3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrt.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", Textnumara.Text);
        
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.ogrenciNotKayıtDbDataSet.TBLDERS);

        }
    }
}
