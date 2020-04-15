using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
namespace Uçuş_Kayıt
{
    public partial class ucus_kayit : Form
    {
        public static int kayitGüncelle = 0, ucusno = 0;
        public ucus_kayit()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Uçus Kayit Defteri Veri Tabani\\ucusKayitDefteri.accdb'"); 
        OleDbCommand sorgu = new OleDbCommand();
        DataSet al = new DataSet();
        DataView goster = new DataView();
        OleDbDataAdapter verial;
        OleDbDataReader dr;
        int sayac = 0, t1, t2, t3, t4, tt1, tt2, tt3, tt4, saat, saat2, saat3, saat4, saat5, tt5, b1, b2, b3, b4;
        void cek()
        {
            Uçuş_Kayıt.classlar topla = new Uçuş_Kayıt.classlar();
            al.Clear();
            verial = new OleDbDataAdapter("select * from tablo", baglan);
            verial.Fill(al, "tablo");
            goster.Table = al.Tables[0];
            dataGridView1.DataSource = goster;
            dataGridView1.Columns["ucus_no"].Visible = false;

            try
            {
                label11.Text = topla.top(label11.Text, 1);
                t1 = Convert.ToInt32(label11.Text);
                label12.Text = topla.top(label12.Text, 2);
                t2 = Convert.ToInt32(label12.Text);
                label13.Text = topla.top(label13.Text, 3);
                t3 = Convert.ToInt32(label13.Text);
                label14.Text = topla.top(label14.Text, 4);
                t4 = Convert.ToInt32(label14.Text);
                label15.Text = (t1 + t2 + t4 + t3).ToString();
                //
                tt1 = Convert.ToInt32(topla.top2(label16.Text, 1));
                b1 = Convert.ToInt32(topla.top2(label16.Text, 1));
                if (tt1 % 60 == 0)
                {
                    saat = tt1 / 60;
                    tt1 = 0;
                }
                else
                {
                    saat = (tt1 / 60);
                    tt1 = tt1 - (saat * 60);
                }
                if (saat == 0 && tt1 == 0)
                {
                    label16.Text = "0";
                }
                else if (tt1 == 0)
                {
                    label16.Text = saat.ToString() + " Saat";
                }
                else if (saat == 0)
                {
                    label16.Text = tt1.ToString() + " Dakika";
                }
                else
                {
                    label16.Text = saat + " Saat " + tt1.ToString() + " Dakika";
                }
                tt2 = Convert.ToInt32(topla.top2(label17.Text, 2));
                b2 = Convert.ToInt32(topla.top2(label17.Text, 2));
                if (tt2 % 60 == 0)
                {
                    saat2 = tt2 / 60;
                    tt2 = 0;
                }
                else
                {
                    saat2 = (tt2 / 60);
                    tt2 = tt2 - (saat2 * 60);
                }
                if (saat2 == 0 && tt2 == 0)
                {
                    label17.Text = "0";
                }
                else if (tt2 == 0)
                {
                    label17.Text = saat2.ToString() + " Saat";
                }
                else if (saat2 == 0)
                {
                    label17.Text = tt2.ToString() + " Dakika";
                }
                else
                {
                    label17.Text = saat2 + " Saat " + tt2.ToString() + " Dakika";
                }

                tt3 = Convert.ToInt32(topla.top2(label18.Text, 3));
                b3 = Convert.ToInt32(topla.top2(label18.Text, 3));
                if (tt3 % 60 == 0)
                {
                    saat3 = tt3 / 60;
                    tt3 = 0;
                }
                else
                {
                    saat3 = (tt3 / 60);
                    tt3 = tt3 - (saat3 * 60);
                }
                if (saat3 == 0 && tt3 == 0)
                {
                    label18.Text = "0";
                }
                else if (saat3 == 0)
                {
                    label18.Text = tt3.ToString() + " Dakika";
                }
                else if (tt3 == 0)
                {
                    label18.Text = saat3.ToString() + " Saat";
                }
                else
                {
                    label18.Text = saat3 + " Saat " + tt3.ToString() + " Dakika";
                }

                tt4 = Convert.ToInt32(topla.top2(label19.Text, 4));
                b4 = Convert.ToInt32(topla.top2(label19.Text, 4));
                if (tt4 % 60 == 0)
                {
                    saat4 = tt4 / 60;
                    tt4 = 0;
                }
                else
                {
                    saat4 = (tt4 / 60);
                    tt4 = tt4 - (saat4 * 60);
                }
                if (saat4 == 0 && tt4 == 0)
                {
                    label19.Text = "0";
                }
                else if (saat4 == 0)
                {
                    label19.Text = tt4.ToString() + " Dakika";
                }
                else if (tt4 == 0)
                {
                    label19.Text = saat4.ToString() + " Saat";
                }
                else
                {
                    label19.Text = saat4 + " Saat " + tt4.ToString() + " Dakika";
                }

                tt5 = b1 + b2 + b3 + b4;
                if (tt5 % 60 == 0)
                {
                    saat5 = tt5 / 60;
                    tt5 = 0;
                }
                else
                {
                    saat5 = (tt5 / 60);
                    tt5 = tt5 - (saat5 * 60);
                }
                if (saat5 == 0 && tt5 == 0)
                {
                    label20.Text = "0";
                }
                else if (tt5 == 0)
                {
                    label20.Text = saat5.ToString() + " Saat";
                }
                else if (saat5 == 0)
                {
                    label20.Text = tt5.ToString() + " Dakika";
                }
                else
                {
                    label20.Text = saat5 + " Saat " + tt5.ToString() + " Dakika";
                }
            }
            catch
            {
            }
        }
    
        private void ucus_kayit_Load(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "select * from giriskismi";
                dr = sorgu.ExecuteReader();
                dr.Read();
                label21.Text = ("Adı Soyadı :  " + dr[3] + " " + dr[4] + " - Doğum Tarihi : " + dr[5]).ToString();
                kayitGüncelle = 0;
                cek();
                dataGridView1.AllowUserToOrderColumns = false;
                dataGridView1.Columns[8].Width = 40;
                dataGridView1.Columns[1].Width = 83;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[9].Width = 80;
                dataGridView1.Columns[10].Width = 80;
                dataGridView1.Columns[11].Width = 80;
                dataGridView1.Columns[12].Width = 80;
                dataGridView1.Columns[14].Width = 70;
                dataGridView1.Columns[16].Width = 50;
                dataGridView1.Columns[17].Width = 60;
                dataGridView1.Columns[18].Width = 65;
                dataGridView1.Columns[20].Width = 90;
                dataGridView1.Columns[22].Width = 150;
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[14].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[15].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[16].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[17].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[18].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[19].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[20].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[21].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[22].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].HeaderText = "Tarih";
                dataGridView1.Columns[2].HeaderText = "Uçuş Tipi";
                dataGridView1.Columns[3].HeaderText = "Paraşüt Tipi";
                dataGridView1.Columns[4].HeaderText = "(Uçuş Adedi) YP";
                dataGridView1.Columns[5].HeaderText = "(Uçuş Adedi) TYP";
                dataGridView1.Columns[6].HeaderText = "(Uçuş Adedi) MYP";
                dataGridView1.Columns[7].HeaderText = "(Uçuş Adedi) YP.V.K";
                dataGridView1.Columns[8].HeaderText = " ";
                dataGridView1.Columns[9].HeaderText = "(Uçuş Süresi) YP";
                dataGridView1.Columns[10].HeaderText = "(Uçuş Süresi) TYP";
                dataGridView1.Columns[11].HeaderText = "(Uçuş Süresi) MYP";
                dataGridView1.Columns[12].HeaderText = "(Uçuş Süresi) YP.V.K";
                dataGridView1.Columns[13].HeaderText = "Kalkış Yeri";
                dataGridView1.Columns[14].HeaderText = "Kalkiş Yeri Yüksekliği";
                dataGridView1.Columns[15].HeaderText = "İniş Yeri";
                dataGridView1.Columns[16].HeaderText = "Çıkış Türü";
                dataGridView1.Columns[17].HeaderText = "İrtifa Kazanma";
                dataGridView1.Columns[18].HeaderText = "Uçuş Mesafesi";
                dataGridView1.Columns[19].HeaderText = "Hava Durumu";
                dataGridView1.Columns[20].HeaderText = "Rüzgar Yönü";
                dataGridView1.Columns[21].HeaderText = "Rüzgar Hızı";
                dataGridView1.Columns[22].HeaderText = "Düşünceler";
            }
            catch
            { }
        }

        private void ucus_kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 0;
            System.Windows.Forms.Application.Exit();
        } 
        private void button3_Click(object sender, EventArgs e)
        {
            sayac += 1;
            if (sayac == 1)
            {
                button3.BackColor = Color.Red;
                MessageBox.Show("Lütfen İşlem Yapmak İstediğiniz Kaydın Üstüne Çift Tıklayınız");            

            }
            else
            {
                button3.BackColor = Color.White;
                sayac = 0;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sayac >= 1)
            {
                ucusno = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ucus_no"].Value);
                kayitGüncelle = 1;
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "select * from tablo where ucus_no='" + ucusno + "'";
                dr = sorgu.ExecuteReader();
                dr.Read();
                ucusno = int.Parse(dr[0].ToString());
                kayit_ekle frm = new kayit_ekle();
                this.Hide();
                frm.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kayit_ekle frm = new kayit_ekle();
            frm.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            al.Clear();
            verial = new OleDbDataAdapter("select * from tablo where tarih='" + dateTimePicker1.Text + "'", baglan);
            verial.Fill(al, "tablo");
            goster.Table = al.Tables[0];
            dataGridView1.DataSource = goster;
            verial.Dispose();
            dataGridView1.Columns["ucus_no"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cek();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            Hide();
        }
        int sayaccc;
        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Close();
            baglan.Open();
            sorgu.Connection = baglan;
            sorgu.CommandText = "select * from tablo";
            dr = sorgu.ExecuteReader();
            while (dr.Read()) 
            {
                sayaccc += 1;
            }
            if (sayaccc >0)
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiç Kayıt Bulunamadı");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/iskenderunyamacparasut/");
        }

    }
}
