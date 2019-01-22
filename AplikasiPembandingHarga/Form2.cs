using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AplikasiPembandingHarga
{
    public partial class Form2 : Form
    {

       
        public Form2(String asal, String tujuan, String Cm, String berat)
        {
            try
            {
                InitializeComponent();
                lblTujuan.Text = tujuan;
                lblAsal.Text = asal;
                lblCm.Text = Cm;
                lblgram.Text = berat;

            }catch(Exception e)
            {
                MessageBox.Show("Panjang, Lebar, Tinggi tidak boleh kosong");
            }

        }

       int diskonF2 = 0;
        string urutan="asc";
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projek\skripsi dika\DBSkripsiDIka.accdb";
      /*  string name;
        int i;
        DataGridView dgv;
        DataGridViewRow dgr;
        DataGridViewTextBoxColumn textcol = new DataGridViewTextBoxColumn();
        DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
       * */

        public string KAsal
        {
            get { return lblAsal.Text; }
        }

        public string KTujuan
        {
            get { return lblTujuan.Text; }
        }

        public string Path { get; set; }

        public Image Picture
        {
            get 
            {
                if (!string.IsNullOrEmpty(Path))
                {
                    if (File.Exists(Path))
                        return Image.FromFile(Path);
                }
                return null;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             lblTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
             timer1_Tick(sender, null);
             


             showSemuaData();
        }

        private void showSemuaData()
        {
              showDgvHarga();
              showDgvEkspedisi();
              showDgvPromo();
              showDgvWaktu();

        }

        private void showDgvHarga()
        {
            try{
            float temp = 0,temp2=0;
            int tempint = 0;
            if (Int32.Parse(lblCm.Text) <= 18000)
            {
                
                    temp = float.Parse(lblgram.Text);
                    tempint = (int)temp;
                    int index = temp.ToString().IndexOf(",");
                    try
                    {
                        temp2 = float.Parse(temp.ToString().Substring(index, 2));
                    }
                    catch (Exception ex)
                    {
                        temp = tempint;
                    }
                    if (temp2 >= (0.5))
                    {
                        temp = tempint + 1;

                    }
                    else
                    {
                        temp = tempint;
                    }
            }
            else
            {
                    temp = float.Parse(lblCm.Text)/6000;
                    tempint = (int) temp;
                    int index = temp.ToString().IndexOf(",");
                    try
                    {
                        temp2 = float.Parse(temp.ToString().Substring(index, 2));
                    }
                    catch (Exception ex)
                    {
                        temp = tempint;
                    }
                    if (temp2 >= (0.5))
                    {
                        temp = tempint + 1;

                    }
                    else {
                        temp = tempint;
                    }
                    
            }
            string query = "SELECT path, Lama_Hari, Tarif*" + temp + " as Biaya, Ekspedisi From JNE where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' order by Tarif " + urutan + "";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    // Create the DGV with an Image column
                    DataGridViewImageCell imageCol = new DataGridViewImageCell();
                    DataGridViewTextBoxCell kolom = new DataGridViewTextBoxCell();

                    dgvHarga.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Biaya", Name = "Biaya" });
                    dgvHarga.Columns.Add(new DataGridViewImageColumn() { CellTemplate = imageCol, FillWeight = 1, HeaderText = "Ekspedisi", Name = "Ekspedisi" });
                    dgvHarga.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Lama Hari", Name = "Lama Hari" });
                    dgvHarga.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "eks", Name = "eks", Width = 0 });

                    Bitmap img;
                    int size = ds.Tables[0].Select("Path is not null").Length;
                 
                    for (int i = 0; i < size; i++)
                    {
                        String biaya = ds.Tables[0].Rows[i]["Biaya"].ToString();
                        String path = ds.Tables[0].Rows[i]["Path"].ToString();
                        String lama = ds.Tables[0].Rows[i]["Lama_Hari"].ToString();
                        String eks = ds.Tables[0].Rows[i]["Ekspedisi"].ToString();

                        img = new Bitmap(@""+path+"");
                     //   dgvHarga.Rows.Add(img, lama, biaya);
                        dgvHarga.Rows.Add(biaya,img,lama,eks);
                       
                    }

                    



                }
            

             }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

          
        }

        private void showDgvPromo() //belum selse
        {
            float temp = 0, temp2 = 0;
            int tempint = 0;
            if (Int32.Parse(lblCm.Text) <= 18000)
            {

                temp = float.Parse(lblgram.Text);
                tempint = (int)temp;
                int index = temp.ToString().IndexOf(",");
                try
                {
                    temp2 = float.Parse(temp.ToString().Substring(index, 2));
                }
                catch (Exception ex)
                {
                    temp = tempint;
                }

                if (temp2 >= (0.5))
                {
                    temp = tempint + 1;

                }
                else
                {
                    temp = tempint;
                }

                
            }
            else
            {
                temp = float.Parse(lblCm.Text) / 6000;
                tempint = (int)temp;
                int index = temp.ToString().IndexOf(",");
                try
                {
                    temp2 = float.Parse(temp.ToString().Substring(index, 2));
                }
                catch (Exception ex)
                {
                    temp = tempint;
                }
                if (temp2 >= (0.5))
                {
                    temp = tempint + 1;

                }
                else
                {
                    temp = tempint;
                }

            }


            string query = "SELECT Path,  Lama_Hari, Tarif*" + temp + " as Biaya, Tarif_Diskon, ekspedisi From Promosi where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "'";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataGridViewImageCell imageCol = new DataGridViewImageCell();
                    DataGridViewTextBoxCell kolom = new DataGridViewTextBoxCell();

                    dgvPromo.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Harga Normal", Name = "Harga Normal", Width = 75 });
                    dgvPromo.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Promo", Name = "Promo", Width = 75 });
                    dgvPromo.Columns.Add(new DataGridViewImageColumn() { CellTemplate = imageCol, FillWeight = 1, HeaderText = "Ekspedisi", Name = "Ekspedisi", Width=100});
                    dgvPromo.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Lama Hari", Name = "Lama Hari", Width = 50 });
                    dgvPromo.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "eks", Name = "eks", Width = 0 });

                    Bitmap img;
                    int size = ds.Tables[0].Select("Path is not null").Length;

                    for (int i = 0; i < size; i++)
                    {
                        String biaya = ds.Tables[0].Rows[i]["Biaya"].ToString();
                        String promo = ds.Tables[0].Rows[i]["Tarif_Diskon"].ToString();
                        String path = ds.Tables[0].Rows[i]["Path"].ToString();
                        String lama = ds.Tables[0].Rows[i]["Lama_Hari"].ToString();
                        String eks = ds.Tables[0].Rows[i]["Ekspedisi"].ToString();
                       
                        img = new Bitmap(@""+path+"");
                        //   dgvHarga.Rows.Add(img, lama, biaya);
                        dgvPromo.Rows.Add(biaya, promo,img, lama, eks);

                    }

                }
            }
        }

        private void showDgvEkspedisi()
        {
            try
            {

                string tempJne = "", tempPos = "", tempTiki = "";

                if (cbJNE.Checked == true)
                {
                    tempJne = "JNE";
                }
                if (cbIndo.Checked == true)
                {
                    tempPos = "PosIndo";
                }
                if (cbTiki.Checked == true)
                {
                    tempTiki = "TIKI";
                }

                float temp = 0, temp2 = 0;
                int tempint = 0;
                if (Int32.Parse(lblCm.Text) <= 18000)
                {

                    temp = float.Parse(lblgram.Text);
                    tempint = (int)temp;
                    int index = temp.ToString().IndexOf(",");
                    try
                    {
                        temp2 = float.Parse(temp.ToString().Substring(index, 2));
                    }
                    catch (Exception ex)
                    {
                        temp = tempint;
                    }
                    if (temp2 >= (0.5))
                    {
                        temp = tempint + 1;

                    }
                    else
                    {
                        temp = tempint;
                    }
                }
                else
                {
                    temp = float.Parse(lblCm.Text) / 6000;
                    tempint = (int)temp;
                    int index = temp.ToString().IndexOf(",");
                    temp2 = float.Parse(temp.ToString().Substring(index, 2));
                    if (temp2 >= (0.5))
                    {
                        temp = tempint + 1;

                    }
                    else
                    {
                        temp = tempint;
                    }

                }
                string query = "SELECT path, Lama_Hari, Tarif*" + temp + " as Biaya, Ekspedisi From JNE where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Ekspedisi='" + tempJne + "' or   Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Ekspedisi='" + tempPos + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Ekspedisi='" + tempTiki + "' order by Tarif asc";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        // Create the DGV with an Image column
                        DataGridViewImageCell imageCol = new DataGridViewImageCell();
                        DataGridViewTextBoxCell kolom = new DataGridViewTextBoxCell();

                        dgvExpedisi.Columns.Add(new DataGridViewImageColumn() { CellTemplate = imageCol, FillWeight = 1, HeaderText = "Ekspedisi", Name = "Ekspedisi" });
                        dgvExpedisi.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Lama Hari", Name = "Lama Hari" });
                        dgvExpedisi.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Biaya", Name = "Biaya" });
                        dgvExpedisi.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "eks", Name = "eks", Width = 0 });

                        Bitmap img;
                        int size = ds.Tables[0].Select("Path is not null").Length;

                        for (int i = 0; i < size; i++)
                        {
                            String path = ds.Tables[0].Rows[i]["Path"].ToString();
                            String lama = ds.Tables[0].Rows[i]["Lama_Hari"].ToString();
                            String biaya = ds.Tables[0].Rows[i]["Biaya"].ToString();
                            String eks = ds.Tables[0].Rows[i]["Ekspedisi"].ToString();

                            img = new Bitmap(@"" + path + "");
                            //   dgvHarga.Rows.Add(img, lama, biaya);
                            dgvExpedisi.Rows.Add(img, lama, biaya, eks);

                        }





                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada Error disini bro ===>>> " + ex.ToString() + "");
            }

        }

        private void showDgvWaktu()
        {
            try
            {
                float temp = 0, temp21 = 0;
                int tempint = 0;
                string temp1 = "", temp2 = "", temp3 = "", temp4 = "", temp5 = "", temp6 = "", temp7 = "", temp8 = "";
                if (cb12.Checked == true)
                {
                    temp1 = "1%";
                    temp2 = "%2%";
                }
                if (cb34.Checked == true)
                {
                    temp3 = "%3%";
                    temp4 = "%4%";
                }
                if (cb56.Checked == true)
                {
                    temp5 = "%5%";
                    temp6 = "%6%";
                }
                if (cb78.Checked == true)
                {
                    temp7 = "%7%";
                    temp8 = "%8";
                }
                if (cb12.Checked == false)
                {
                    temp1 = "";
                    temp2 = "";
                }
                if (cb34.Checked == false)
                {
                    temp3 = "";
                    temp4 = "";
                }
                if (cb56.Checked == false)
                {
                    temp5 = "";
                    temp6 = "";
                }
                if (cb78.Checked == false)
                {
                    temp7 = "";
                    temp8 = "";
                }


                if (float.Parse(lblCm.Text) <= 18000)
                {

                    temp = float.Parse(lblgram.Text);
                    tempint = (int)temp;
                    int index = temp.ToString().IndexOf(",");
                    try
                    {
                        temp21 = float.Parse(temp.ToString().Substring(index, 2));
                    }
                    catch (Exception ex)
                    {
                        temp = tempint;
                    }
                    if (temp21 >= (1 / 2))
                    {
                        temp = tempint + 1;

                    }
                    else
                    {
                        temp = tempint;
                    }
                }
                else
                {
                    temp = float.Parse(lblCm.Text) / 6000;
                    tempint = (int)temp;
                    int index = temp.ToString().IndexOf(",");
                    temp21 = float.Parse(temp.ToString().Substring(index, 2));
                    if (temp21 >= 1 / 2)
                    {
                        temp = tempint + 1;

                    }
                    else
                    {
                        temp = tempint;
                    }

                }

                // string query = "SELECT Ekspedisi, Lama_Hari, Tarif From JNE where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '%" + temp12 + "' or Lama_Hari like ' " + temp34 + " ' or Lama_Hari like '%" + temp45 + "%' or Lama_Hari like '%" + temp56 + "%' or Lama_Hari like '%" + temp78 + "%' ";
                string query = "SELECT path,  Lama_Hari, Tarif*" + temp + " as Biaya, Ekspedisi From JNE where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp1 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp2 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp3 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like ' " + temp4 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp5 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp6 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp7 + "' or Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Lama_Hari like '" + temp8 + "'";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        DataGridViewImageCell imageCol = new DataGridViewImageCell();
                        DataGridViewTextBoxCell kolom = new DataGridViewTextBoxCell();

                        dgvWaktu.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Lama Hari", Name = "Lama Hari" });    
                        dgvWaktu.Columns.Add(new DataGridViewImageColumn() { CellTemplate = imageCol, FillWeight = 1, HeaderText = "Ekspedisi", Name = "Ekspedisi" });
                        dgvWaktu.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "Biaya", Name = "Biaya" });
                        dgvWaktu.Columns.Add(new DataGridViewColumn() { CellTemplate = kolom, FillWeight = 1, HeaderText = "eks", Name = "eks", Width = 0 });

                        Bitmap img;
                        int size = ds.Tables[0].Select("Path is not null").Length;

                        for (int i = 0; i < size; i++)
                        {
                            String lama = ds.Tables[0].Rows[i]["Lama_Hari"].ToString();
                            String path = ds.Tables[0].Rows[i]["Path"].ToString();
                            String biaya = ds.Tables[0].Rows[i]["Biaya"].ToString();
                            String eks = ds.Tables[0].Rows[i]["Ekspedisi"].ToString();

                            img = new Bitmap(@"" + path + ""); 
                            //   dgvHarga.Rows.Add(img, lama, biaya);
                            dgvWaktu.Rows.Add(lama, img, biaya, eks);

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada error bro di dgvWaktu====>" + ex.ToString() + "");
            }
        }


        private void dgvPromo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtEks.Text = getKolom(dgvHarga, 4);
                txtLama.Text = getKolom(dgvHarga, 3);
                txtTarif.Text = getKolom(dgvHarga, 0);
                txtharganormal.Text = getKolom(dgvHarga, 3);
                diskonF2 = Int32.Parse(getKolom(dgvPromo, 0)) - Int32.Parse(getKolom(dgvPromo, 3));
            }catch(Exception ex)
            {
            
            }
        }

        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPromo_KeyUp( sender, null);
        }

        private void dgvPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPromo_KeyUp( sender,  null);
        }

        private string getKolom(DataGridView dg, int i)
        {
            try
            {
                return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private string getKolomWaktu(DataGridView dg, int i)
        {
            try
            {
                return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private string getKolomEkspedisi(DataGridView dg, int i)
        {
            try
            {
                return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private string getKolomPromo(DataGridView dg, int i)
        {
            try
            {
                return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void dgvHarga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgvHarga_KeyUp(object sender, KeyEventArgs e)
        {
            txtEks.Text = getKolom(dgvHarga, 3);
            txtLama.Text = getKolom(dgvHarga, 2);
            txtTarif.Text = getKolom(dgvHarga, 0);
            txtharganormal.Text = getKolom(dgvHarga, 0);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            txtEks.Text = "";
            txtLama.Text = "";
            txtTarif.Text = "";

        }

        private void hilangkanSemuaKolom() 
        {
            hilangkanKolomDgvEkspedisi();
            hilangkanKolomDgvHarga();
            hilangkanKolomDgvWaktu();
            hilangkanKolomDgvPromo();
        }

        private void hilangkanKolomDgvHarga()
        {
            try
            {
                int i = 3;
                for (; i >= 0; i--)
                {
                    dgvHarga.Columns.RemoveAt(i);
                }
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void hilangkanKolomDgvEkspedisi()
        {
            try
            {
                int i = 3;
                for (; i >= 0; i--)
                {
                    dgvExpedisi.Columns.RemoveAt(i);
                }
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void hilangkanKolomDgvWaktu()
        {
            try
            {
                int i = 3;
                for (; i >= 0; i--)
                {
                    dgvWaktu.Columns.RemoveAt(i);
                }
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void hilangkanKolomDgvPromo()
        {
            try
            {
                int i = 4;
                for (; i >= 0; i--)
                {
                    dgvPromo.Columns.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void txtTarif_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Ekspedisi, Lama_Hari, Tarif From JNE where Kota_Asal='" + lblAsal.Text + "' and Kota_Tujuan='" + lblTujuan.Text + "' and Tarif like '%" + txtTarif.Text + "'%'";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvHarga.DataSource = ds.Tables[0];
                    }
                }
            }
            catch {
                
            }
        }


        private void btnTampil_Click(object sender, EventArgs e)
        {
            try {
                hilangkanKolomDgvEkspedisi();
            }
            finally{
                showDgvEkspedisi();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hilangkanKolomDgvHarga();
            if(cmbHarga.SelectedIndex==1)
            {
                urutan = "desc";
            }
            else 
            {
                urutan = "asc";
               
            }
            Form2_Load(sender, null);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide(); 
            f1.Show();
           
        }
        


        

        private void dgvExpedisi_KeyUp(object sender, KeyEventArgs e)
        {
            txtEks.Text = getKolom(dgvExpedisi, 3);
            txtLama.Text = getKolom(dgvExpedisi, 1);
            txtTarif.Text = getKolom(dgvExpedisi, 2);
            txtharganormal.Text = getKolom(dgvExpedisi, 2);
        }

        private void dgvExpedisi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExpedisi_KeyUp(sender, null);
        }

        private void dgvExpedisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExpedisi_KeyUp(sender, null);
        }

        private void btnTampilWaktu_Click(object sender, EventArgs e)
        {
            try
            {
                hilangkanKolomDgvWaktu();
                
            }
            finally
            {

                showDgvWaktu();
            }
        }

        private void dgvWaktu_KeyUp(object sender, KeyEventArgs e)
        {
            txtEks.Text = getKolom(dgvWaktu, 3);
            txtLama.Text = getKolom(dgvWaktu, 0);
            txtTarif.Text = getKolom(dgvWaktu, 2);
            txtharganormal.Text = getKolom(dgvWaktu, 2);
        }

        private void dgvWaktu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvWaktu_KeyUp(sender, null);
        }

        private void dgvWaktu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvWaktu_KeyUp(sender, null);
        }

        private void cbSemua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSemua.Checked == true)
            {
                cb12.Checked = true;
                cb34.Checked = true;
                cb56.Checked = true;
                cb78.Checked = true;
            }
            else if (cbSemua.Checked == false)
            {
                cb12.Checked = false;
                cb34.Checked = false;
                cb56.Checked = false;
                cb78.Checked = false;
            }
        }

        private void btnPilihTarif_Click(object sender, EventArgs e)
        {
            if (txtTarif.Text != null)
            {
                Form3 frm3 = new Form3(lblAsal.Text, lblTujuan.Text, lblCm.Text, lblgram.Text, txtEks.Text,txtLama.Text, diskonF2,Int32.Parse(txtTarif.Text),Int32.Parse(txtharganormal.Text));
                this.Hide();
                frm3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Isikan semua data terlebih dahulu pada textbox yang disediakan");
            }
        }

        private void dgvHarga_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHarga_KeyUp(sender, null);
        }

        private void dgvHarga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHarga_KeyUp(sender, null);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString("hh:mm:ss"); 
        }



 


    }
}
