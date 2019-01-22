using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPembandingHarga
{
    public partial class Form3 : Form
    {
        public Form3(String asal, String tujuan, String dimensi, String berat, String Ekspedisi, String LamaHari, int diskon, int biaya, int harganormal )
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("id-ID");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("id-ID");
                InitializeComponent();
                lblAsalf3.Text = asal;
                lblTujF3.Text = tujuan;
                lblgram.Text = berat;
                lblCm.Text = dimensi;
                lblEkspedisi.Text = Ekspedisi;
                lblLamaWkt.Text = LamaHari;
                lblHarga.Text = harganormal.ToString("C");
                lblDiskon.Text = diskon.ToString("C");
                lblTotalHarga.Text = biaya.ToString("C");

            }catch(Exception e)
            {
            
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1_Tick(sender, null);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(lblAsalf3.Text, lblTujF3.Text, lblCm.Text, lblgram.Text);
            this.Hide();
            f2.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
