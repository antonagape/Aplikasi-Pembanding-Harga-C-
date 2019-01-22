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
using System.Threading;
using System.Globalization;


namespace AplikasiPembandingHarga
{
    public partial class Form1 : Form
    {
        public Form2 f2;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadComboAsal();
            LoadComboTujuan();
            cmbAsal.Text = "======Masukkan Kota Asal======";
            cmbTujuan.Text = "======Masukkan Kota Tujuan======";
        }

        //Untuk mengambil data dari combobox asal
        private void LoadComboAsal()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");

            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projek\skripsi dika\DBSkripsiDIka.accdb";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    string strSql = "SELECT Kota_Asal FROM JNE Group by Kota_Asal";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cmbAsal.DataSource = ds.Tables[0];
                    cmbAsal.DisplayMember = "Masukan Kota Asal";
                    cmbAsal.ValueMember = "Kota_Asal";

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadComboTujuan()
        {
           // AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");

            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projek\skripsi dika\DBSkripsiDIka.accdb";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    string strSql = "SELECT Kota_Tujuan FROM JNE Group by Kota_Tujuan";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cmbTujuan.DataSource = ds.Tables[0];
                    cmbTujuan.DisplayMember = "Kota_Tujuan";
                 //   cmbTujuan.ValueMember = "Kota_Tujuan";

                }
            }
            catch (Exception ex)
            {

            }



        }



        private void btnCek_Click(object sender, EventArgs e)
        {
            String AsalTujuanCek;
            string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projek\skripsi dika\DBSkripsiDIka.accdb";
            try
            {
                //Cek COmbo box
                int indexAsal = cmbAsal.FindString(cmbAsal.Text.ToString());
                int indexTujuan = cmbAsal.FindString(cmbAsal.Text.ToString());
                if (indexAsal!=-1 && indexTujuan!=-1)
                {
                    var count = cmbAsal.Items.Count;
                    int cek = 0;


                    float templebar, temppanjang, temptinggi;
                    if (txtBerat.Text != "" && txtLebar.Text != "" && txtPanjang.Text != "" && txtTinggi.Text != "")
                    {
                        templebar = float.Parse(txtLebar.Text);
                        temppanjang = float.Parse(txtPanjang.Text);
                        temptinggi = float.Parse(txtTinggi.Text);

                        //   for (int i = 0; i <= templebar; i++)

                        if (templebar != 0)
                        {
                            txtLebar.Text = (float.Parse(txtLebar.Text)).ToString();
                        }
                        if (temppanjang != 0)
                        {
                            txtPanjang.Text = (float.Parse(txtPanjang.Text)).ToString();
                        }
                        if (temptinggi != 0)
                        {
                            txtTinggi.Text = (float.Parse(txtTinggi.Text)).ToString();
                        }
                        String Cm = (float.Parse(txtLebar.Text) * float.Parse(txtPanjang.Text) * float.Parse(txtTinggi.Text)).ToString();
                        Form2 frm2 = new Form2(cmbAsal.Text, cmbTujuan.Text, Cm, txtBerat.Text);
                        this.Hide();
                        frm2.Show();
                       


                    }
                    else
                    {
                        MessageBox.Show("Isikan semua data terlebih dahulu pada kolom yang disediakan");
                    }


                }
                else {
                    MessageBox.Show("Tidak ada Ekspedisi dari Kota "+cmbAsal.Text.ToString()+" ke "+cmbTujuan.Text.ToString()+", silakan coba lagi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtPanjang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44 )
            {

                e.Handled = false;
                

            }

            else
            {

                e.Handled = true;
                MessageBox.Show("Panjang hanya bisa diinputkan angka dan koma");

            } if (e.KeyChar == (char)13)
            {

                txtPanjang.Text = string.Format("{0:n0}", double.Parse(txtPanjang.Text));
                
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLebar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44)
            {

                e.Handled = false;
                

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Lebar hanya bisa diinputkan angka dan koma   ");

            } if (e.KeyChar == (char)13)
            {

                txtLebar.Text = string.Format("{0:n0}", double.Parse(txtPanjang.Text));

            }

        }

        private void txtTinggi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44)
            {

                e.Handled = false;
                

            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Tinggi hanya bisa diinputkan angka dan koma ");

            } if (e.KeyChar == (char)13)
            {

                txtTinggi.Text = string.Format("{0:n0}", double.Parse(txtPanjang.Text));

            }

        }

        private void txtBerat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8 || (int)e.KeyChar == 44)
            {

                e.Handled = false;
                
                
            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Berat hanya bisa diinputkan angka dan koma   ");
            } if (e.KeyChar == (char)13)
            {

                txtBerat.Text = string.Format("{0:n0}", double.Parse(txtPanjang.Text));

            }

        }


        
        private void cmbAsal_TextChanged(object sender, EventArgs e)
        {
            if (cmbAsal.Text == "")
            {
                cmbAsal.Text = "======Masukkan Kota Asal======";

            }
        }



        private void cmbTujuan_TextChanged(object sender, EventArgs e)
        {
            if (cmbTujuan.Text == "")
            {
                cmbTujuan.Text = "======Masukkan Kota Tujuan======";

            }
        }


        private void cmbAsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {

                e.Handled = false;
                
                
            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Kota Asal dan Kota Tujuan hanya dapat diinputkan huruf   ");
            } 
        }

        private void cmbTujuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {

                e.Handled = false;


            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Kota Asal dan Kota Tujuan hanya dapat diinputkan huruf   ");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            this.Hide();
            frm2.Show();
        }
    }
}

