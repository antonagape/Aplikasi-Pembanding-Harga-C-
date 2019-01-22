using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AplikasiPembandingHarga
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
                    
                   // Add a row and set its value to the image

                    

                    
          
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            this.Hide();
            frm2.Show();
            this.Close();
        }
    }
}
