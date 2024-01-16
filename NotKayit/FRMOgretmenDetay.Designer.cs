namespace NotKayit
{
    partial class FRMOgretmenDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbogrekle = new System.Windows.Forms.GroupBox();
            this.btnOgrkyt = new System.Windows.Forms.Button();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Textnumara = new System.Windows.Forms.MaskedTextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textS3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textS2 = new System.Windows.Forms.TextBox();
            this.textS1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKalanSayisi = new System.Windows.Forms.Label();
            this.lblGcnSayisi = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciNotKayıtDbDataSet = new NotKayit.OgrenciNotKayıtDbDataSet();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDERSTableAdapter = new NotKayit.OgrenciNotKayıtDbDataSetTableAdapters.TBLDERSTableAdapter();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbogrekle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotKayıtDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbogrekle
            // 
            this.gbogrekle.Controls.Add(this.btnOgrkyt);
            this.gbogrekle.Controls.Add(this.textSoyad);
            this.gbogrekle.Controls.Add(this.textAd);
            this.gbogrekle.Controls.Add(this.label3);
            this.gbogrekle.Controls.Add(this.Textnumara);
            this.gbogrekle.Controls.Add(this.lblad);
            this.gbogrekle.Controls.Add(this.lblnum);
            this.gbogrekle.Location = new System.Drawing.Point(12, 12);
            this.gbogrekle.Name = "gbogrekle";
            this.gbogrekle.Size = new System.Drawing.Size(275, 274);
            this.gbogrekle.TabIndex = 0;
            this.gbogrekle.TabStop = false;
            this.gbogrekle.Text = "Öğrenci Ekle";
            // 
            // btnOgrkyt
            // 
            this.btnOgrkyt.Location = new System.Drawing.Point(101, 192);
            this.btnOgrkyt.Name = "btnOgrkyt";
            this.btnOgrkyt.Size = new System.Drawing.Size(168, 33);
            this.btnOgrkyt.TabIndex = 7;
            this.btnOgrkyt.Text = "Öğrenci Kaydet";
            this.btnOgrkyt.UseVisualStyleBackColor = true;
            this.btnOgrkyt.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(101, 142);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(168, 30);
            this.textSoyad.TabIndex = 6;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(101, 97);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(168, 30);
            this.textAd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // Textnumara
            // 
            this.Textnumara.Location = new System.Drawing.Point(101, 53);
            this.Textnumara.Mask = "00000";
            this.Textnumara.Name = "Textnumara";
            this.Textnumara.Size = new System.Drawing.Size(168, 30);
            this.Textnumara.TabIndex = 2;
            this.Textnumara.ValidatingType = typeof(int);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(55, 97);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(40, 24);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "Ad:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(6, 56);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(89, 24);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Numara:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textS3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.textS2);
            this.groupBox1.Controls.Add(this.textS1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav Notları";
            // 
            // textS3
            // 
            this.textS3.Location = new System.Drawing.Point(102, 141);
            this.textS3.Name = "textS3";
            this.textS3.Size = new System.Drawing.Size(168, 30);
            this.textS3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sınav 3:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(102, 177);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(168, 33);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = " Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textS2
            // 
            this.textS2.Location = new System.Drawing.Point(102, 95);
            this.textS2.Name = "textS2";
            this.textS2.Size = new System.Drawing.Size(168, 30);
            this.textS2.TabIndex = 6;
            // 
            // textS1
            // 
            this.textS1.Location = new System.Drawing.Point(102, 53);
            this.textS1.Name = "textS1";
            this.textS1.Size = new System.Drawing.Size(168, 30);
            this.textS1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sınav 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınav 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKalanSayisi);
            this.groupBox2.Controls.Add(this.lblGcnSayisi);
            this.groupBox2.Controls.Add(this.lblOrt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(583, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // lblKalanSayisi
            // 
            this.lblKalanSayisi.AutoSize = true;
            this.lblKalanSayisi.Location = new System.Drawing.Point(160, 141);
            this.lblKalanSayisi.Name = "lblKalanSayisi";
            this.lblKalanSayisi.Size = new System.Drawing.Size(34, 24);
            this.lblKalanSayisi.TabIndex = 11;
            this.lblKalanSayisi.Text = "00";
            // 
            // lblGcnSayisi
            // 
            this.lblGcnSayisi.AutoSize = true;
            this.lblGcnSayisi.Location = new System.Drawing.Point(160, 104);
            this.lblGcnSayisi.Name = "lblGcnSayisi";
            this.lblGcnSayisi.Size = new System.Drawing.Size(34, 24);
            this.lblGcnSayisi.TabIndex = 10;
            this.lblGcnSayisi.Text = "00";
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(160, 59);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(34, 24);
            this.lblOrt.TabIndex = 9;
            this.lblOrt.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kalan Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Geçen Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ortalama:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 371);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrNumaraDataGridViewTextBoxColumn,
            this.ogrAdiDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrS1DataGridViewTextBoxColumn,
            this.ogrS2DataGridViewTextBoxColumn,
            this.ogrS3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciNotKayıtDbDataSet
            // 
            this.ogrenciNotKayıtDbDataSet.DataSetName = "OgrenciNotKayıtDbDataSet";
            this.ogrenciNotKayıtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.ogrenciNotKayıtDbDataSet;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNumaraDataGridViewTextBoxColumn
            // 
            this.ogrNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.HeaderText = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrNumaraDataGridViewTextBoxColumn.Name = "ogrNumaraDataGridViewTextBoxColumn";
            // 
            // ogrAdiDataGridViewTextBoxColumn
            // 
            this.ogrAdiDataGridViewTextBoxColumn.DataPropertyName = "OgrAdi";
            this.ogrAdiDataGridViewTextBoxColumn.HeaderText = "OgrAdi";
            this.ogrAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdiDataGridViewTextBoxColumn.Name = "ogrAdiDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrS1DataGridViewTextBoxColumn
            // 
            this.ogrS1DataGridViewTextBoxColumn.DataPropertyName = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.HeaderText = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS1DataGridViewTextBoxColumn.Name = "ogrS1DataGridViewTextBoxColumn";
            // 
            // ogrS2DataGridViewTextBoxColumn
            // 
            this.ogrS2DataGridViewTextBoxColumn.DataPropertyName = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.HeaderText = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS2DataGridViewTextBoxColumn.Name = "ogrS2DataGridViewTextBoxColumn";
            // 
            // ogrS3DataGridViewTextBoxColumn
            // 
            this.ogrS3DataGridViewTextBoxColumn.DataPropertyName = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.HeaderText = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS3DataGridViewTextBoxColumn.Name = "ogrS3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // FRMOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(849, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbogrekle);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMOgretmenDetay";
            this.Text = "FRMOgretmenDetay";
            this.Load += new System.EventHandler(this.FRMOgretmenDetay_Load);
            this.gbogrekle.ResumeLayout(false);
            this.gbogrekle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciNotKayıtDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbogrekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Textnumara;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnOgrkyt;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox textS2;
        private System.Windows.Forms.TextBox textS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKalanSayisi;
        private System.Windows.Forms.Label lblGcnSayisi;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciNotKayıtDbDataSet ogrenciNotKayıtDbDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private OgrenciNotKayıtDbDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}