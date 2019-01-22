namespace AplikasiPembandingHarga
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbAsal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTujuan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAsal
            // 
            this.cmbAsal.AutoCompleteCustomSource.AddRange(new string[] {
            "Yogyakarta"});
            this.cmbAsal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAsal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAsal.FormattingEnabled = true;
            this.cmbAsal.Items.AddRange(new object[] {
            "Masukan Kota Asal"});
            this.cmbAsal.Location = new System.Drawing.Point(15, 90);
            this.cmbAsal.Name = "cmbAsal";
            this.cmbAsal.Size = new System.Drawing.Size(192, 21);
            this.cmbAsal.TabIndex = 0;
  
            this.cmbAsal.TextChanged += new System.EventHandler(this.cmbAsal_TextChanged);
            this.cmbAsal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAsal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asal Pengiriman";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tujuan Pengiriman";

            // 
            // cmbTujuan
            // 
            this.cmbTujuan.AutoCompleteCustomSource.AddRange(new string[] {
            "Balikpapan",
            "Bandar Lampung",
            "Bandung",
            "Banjarmasin",
            "Batam",
            "Bekasi",
            "Bengkulu",
            "Bogor",
            "Cilegon",
            "Cirebon",
            "Denpasar",
            "Depok",
            "Jakarta",
            "Jambi",
            "Karawang",
            "Kediri",
            "Magelang",
            "Malang",
            "Mataram",
            "Medan",
            "Mojokerto",
            "Padang",
            "Palangkaraya",
            "Palembang",
            "Pangkal Pinang",
            "Pekanbaru",
            "Pontianak",
            "Probolinggo",
            "Semarang",
            "Solo",
            "Sukabumi",
            "Surabaya",
            "Tangerang",
            "Ujung Pandang",
            "Yogyakarta",
            "Banda Aceh",
            "Cilacap",
            "Ngamprah",
            "Samarinda",
            "Tanjung Pandan",
            "Tanjung Pinang",
            "Tarakan",
            "Bontang",
            "Jayapura - Jember",
            "Madiun",
            "Manado",
            "Palu",
            "Pandaan",
            "Jayapura",
            "Nabire",
            "Sorong",
            "Timika",
            "Ambon",
            "Blangpidie",
            "Gorontalo",
            "Kendari",
            "Kupang",
            "Ampana Kota",
            "Benteng",
            "FAK-FAK",
            "Palopo",
            "Pangkalan Balai",
            "Pangkalan Kerinci",
            "Ratahan",
            "Sambas",
            "Sukadana - Lampung Timur",
            "Tarutung",
            "Trenggalek",
            "Tulungagung",
            "Waingapu",
            "Waris",
            "Burmeso",
            "Pemalang",
            "Tais",
            "Tarakan",
            "Ternate"});
            this.cmbTujuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTujuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTujuan.FormattingEnabled = true;
            this.cmbTujuan.Items.AddRange(new object[] {
            "Masukan Kota Tujuan"});
            this.cmbTujuan.Location = new System.Drawing.Point(15, 154);
            this.cmbTujuan.Name = "cmbTujuan";
            this.cmbTujuan.Size = new System.Drawing.Size(192, 21);
            this.cmbTujuan.TabIndex = 1;

            this.cmbTujuan.TextChanged += new System.EventHandler(this.cmbTujuan_TextChanged);
            this.cmbTujuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTujuan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Berat Pengiriman";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(98, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Kg";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(184, 304);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(51, 20);
            this.txtLebar.TabIndex = 4;
            this.txtLebar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLebar_KeyPress);
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(303, 304);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(48, 20);
            this.txtTinggi.TabIndex = 5;
            this.txtTinggi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTinggi_KeyPress);
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.Color.Brown;
            this.btnCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCek.Image = ((System.Drawing.Image)(resources.GetObject("btnCek.Image")));
            this.btnCek.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCek.Location = new System.Drawing.Point(19, 346);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(103, 31);
            this.btnCek.TabIndex = 6;
            this.btnCek.Text = "Cek Tarif";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(6, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(382, 53);
            this.label11.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(166, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 191);
            this.label13.TabIndex = 19;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Silver;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(235, 304);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(21, 20);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "cm";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Silver;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(351, 304);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(21, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "cm";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Silver;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(146, 304);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(38, 20);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = "Lebar";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Silver;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(264, 304);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(39, 20);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "Tinggi";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Silver;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(21, 304);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(48, 20);
            this.textBox8.TabIndex = 24;
            this.textBox8.Text = "Panjang";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Silver;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(117, 304);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(21, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "cm";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(69, 304);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(48, 20);
            this.txtPanjang.TabIndex = 3;
            this.txtPanjang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPanjang_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dimensi Kiriman";
            // 
            // txtBerat
            // 
            this.txtBerat.Location = new System.Drawing.Point(16, 231);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(83, 20);
            this.txtBerat.TabIndex = 2;
            this.txtBerat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBerat_KeyPress);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 53);
            this.label5.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBerat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTujuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAsal);
            this.Controls.Add(this.label13);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTujuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label label5;
    }
}

