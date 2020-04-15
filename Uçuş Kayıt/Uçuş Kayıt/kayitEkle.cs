using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Uçuş_Kayıt
{
    public partial class kayit_ekle : Form
    {
        public kayit_ekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Uçus Kayit Defteri Veri Tabani\\ucusKayitDefteri.accdb'");
        OleDbCommand sorgu = new OleDbCommand();
        DataSet al = new DataSet();
        DataView goster = new DataView();
        OleDbDataReader dr;
        string metre1, metre2, metre3;
        int guncelle = ucus_kayit.kayitGüncelle;
        int ucus_kayıt_no = ucus_kayit.ucusno;
        int aaa1, aaa2, aaa3, sayac;
        int ucus, combo1, combo2, combo3, combo4, combo5, kontrol1, kontrol2, kontrol4, t1, t2, t3, t4, t5, t6, t7, t8;
        int yp_yaz, typ_yaz, myp_yaz, yp_vk_yaz;
        int text_kontrol1, text_kontrol2, text_kontrol3, text_kontrol4, text_kontrol5, text_kontrol6, text_kontrol7, text_kontrol8;
        void duzelt()
        {
            if (text5.Text == "00:05")
            {
                yp_yaz = 5;
            }
            if (text5.Text == "00:10")
            {
                yp_yaz = 10;
            }
            if (text5.Text == "00:15")
            {
                yp_yaz = 15;
            }
            if (text5.Text == "00:20")
            {
                yp_yaz = 20;
            }
            if (text5.Text == "00:25")
            {
                yp_yaz = 25;
            }
            if (text5.Text == "00:30")
            {
                yp_yaz = 30;
            }
            if (text5.Text == "00:35")
            {
                yp_yaz = 35;
            }
            if (text5.Text == "00:40")
            {
                yp_yaz = 40;
            }
            if (text5.Text == "00:45")
            {
                yp_yaz = 45;
            }
            if (text5.Text == "00:50")
            {
                yp_yaz = 50;
            }
            if (text5.Text == "00:55")
            {
                yp_yaz = 55;
            }
            if (text5.Text == "01:00")
            {
                yp_yaz = 60;
            }
            if (text5.Text == "01:05")
            {
                yp_yaz = 65;
            }
            if (text5.Text == "01:10")
            {
                yp_yaz = 70;
            }
            if (text5.Text == "01:15")
            {
                yp_yaz = 75;
            }
            if (text5.Text == "01:20")
            {
                yp_yaz = 80;
            }
            if (text5.Text == "01:25")
            {
                yp_yaz = 85;
            }
            if (text5.Text == "01:30")
            {
                yp_yaz = 90;
            }
            if (text5.Text == "01:35")
            {
                yp_yaz = 95;
            }
            if (text5.Text == "01:40")
            {
                yp_yaz = 100;
            }
            if (text5.Text == "01:45")
            {
                yp_yaz = 105;
            }
            if (text5.Text == "01:50")
            {
                yp_yaz = 110;
            }
            if (text5.Text == "01:55")
            {
                yp_yaz = 115;
            }
            if (text5.Text == "02:00")
            {
                yp_yaz = 120;
            }
            if (text5.Text == "02:15")
            {
                yp_yaz = 135;
            }
            if (text5.Text == "02:30")
            {
                yp_yaz = 150;
            }
            if (text5.Text == "02:45")
            {
                yp_yaz = 165;
            }
            if (text5.Text == "03:00")
            {
                yp_yaz = 180;
            }
            if (text5.Text == "03:15")
            {
                yp_yaz = 195;
            }
            if (text5.Text == "03:30")
            {
                yp_yaz = 210;
            }
            if (text5.Text == "03:45")
            {
                yp_yaz = 225;
            }
            if (text5.Text == "04:00")
            {
                yp_yaz = 240;
            }
            if (text5.Text == "04:15")
            {
                yp_yaz = 255;
            }
            if (text5.Text == "04:30")
            {
                yp_yaz = 270;
            }
            if (text5.Text == "04:45")
            {
                yp_yaz = 285;
            }
            if (text5.Text == "05:00")
            {
                yp_yaz = 300;
            }
            //
            if (text6.Text == "00:05")
            {
                typ_yaz = 5;
            }
            if (text6.Text == "00:10")
            {
                typ_yaz = 10;
            }
            if (text6.Text == "00:15")
            {
                typ_yaz = 15;
            }
            if (text6.Text == "00:20")
            {
                typ_yaz = 20;
            }
            if (text6.Text == "00:25")
            {
                typ_yaz = 25;
            }
            if (text6.Text == "00:30")
            {
                typ_yaz = 30;
            }
            if (text6.Text == "00:35")
            {
                typ_yaz = 35;
            }
            if (text6.Text == "00:40")
            {
                typ_yaz = 40;
            }
            if (text6.Text == "00:45")
            {
                typ_yaz = 45;
            }
            if (text6.Text == "00:50")
            {
                typ_yaz = 50;
            }
            if (text6.Text == "00:55")
            {
                typ_yaz = 55;
            }
            if (text6.Text == "01:00")
            {
                typ_yaz = 60;
            }
            if (text6.Text == "01:05")
            {
                typ_yaz = 65;
            }
            if (text6.Text == "01:10")
            {
                typ_yaz = 70;
            }
            if (text6.Text == "01:15")
            {
                typ_yaz = 75;
            }
            if (text6.Text == "01:20")
            {
                typ_yaz = 80;
            }
            if (text6.Text == "01:25")
            {
                typ_yaz = 85;
            }
            if (text6.Text == "01:30")
            {
                typ_yaz = 90;
            }
            if (text6.Text == "01:35")
            {
                typ_yaz = 95;
            }
            if (text6.Text == "01:40")
            {
                typ_yaz = 100;
            }
            if (text6.Text == "01:45")
            {
                typ_yaz = 105;
            }
            if (text6.Text == "01:50")
            {
                typ_yaz = 110;
            }
            if (text6.Text == "01:55")
            {
                typ_yaz = 115;
            }
            if (text6.Text == "02:00")
            {
                typ_yaz = 120;
            }
            if (text6.Text == "02:15")
            {
                typ_yaz = 135;
            }
            if (text6.Text == "02:30")
            {
                typ_yaz = 150;
            }
            if (text6.Text == "02:45")
            {
                typ_yaz = 165;
            }
            if (text6.Text == "03:00")
            {
                typ_yaz = 180;
            }
            if (text6.Text == "03:15")
            {
                typ_yaz = 195;
            }
            if (text6.Text == "03:30")
            {
                typ_yaz = 210;
            }
            if (text6.Text == "03:45")
            {
                typ_yaz = 225;
            }
            if (text6.Text == "04:00")
            {
                typ_yaz = 240;
            }
            if (text6.Text == "04:15")
            {
                typ_yaz = 255;
            }
            if (text6.Text == "04:30")
            {
                typ_yaz = 270;
            }
            if (text6.Text == "04:45")
            {
                typ_yaz = 285;
            }
            if (text6.Text == "05:00")
            {
                typ_yaz = 300;
            }
            //
            if (text7.Text == "00:05")
            {
                myp_yaz = 5;
            }
            if (text7.Text == "00:10")
            {
                myp_yaz = 10;
            }
            if (text7.Text == "00:15")
            {
                myp_yaz = 15;
            }
            if (text7.Text == "00:20")
            {
                myp_yaz = 20;
            }
            if (text7.Text == "00:25")
            {
                myp_yaz = 25;
            }
            if (text7.Text == "00:30")
            {
                myp_yaz = 30;
            }
            if (text7.Text == "00:35")
            {
                myp_yaz = 35;
            }
            if (text7.Text == "00:40")
            {
                myp_yaz = 40;
            }
            if (text7.Text == "00:45")
            {
                myp_yaz = 45;
            }
            if (text7.Text == "00:50")
            {
                myp_yaz = 50;
            }
            if (text7.Text == "00:55")
            {
                myp_yaz = 55;
            }
            if (text7.Text == "01:00")
            {
                myp_yaz = 60;
            }
            if (text7.Text == "01:05")
            {
                myp_yaz = 65;
            }
            if (text7.Text == "01:10")
            {
                myp_yaz = 70;
            }
            if (text7.Text == "01:15")
            {
                myp_yaz = 75;
            }
            if (text7.Text == "01:20")
            {
                myp_yaz = 80;
            }
            if (text7.Text == "01:25")
            {
                myp_yaz = 85;
            }
            if (text7.Text == "01:30")
            {
                myp_yaz = 90;
            }
            if (text7.Text == "01:35")
            {
                myp_yaz = 95;
            }
            if (text7.Text == "01:40")
            {
                myp_yaz = 100;
            }
            if (text7.Text == "01:45")
            {
                myp_yaz = 105;
            }
            if (text7.Text == "01:50")
            {
                myp_yaz = 110;
            }
            if (text7.Text == "01:55")
            {
                myp_yaz = 115;
            }
            if (text7.Text == "02:00")
            {
                myp_yaz = 120;
            }
            if (text7.Text == "02:15")
            {
                myp_yaz = 135;
            }
            if (text7.Text == "02:30")
            {
                myp_yaz = 150;
            }
            if (text7.Text == "02:45")
            {
                myp_yaz = 165;
            }
            if (text7.Text == "03:00")
            {
                myp_yaz = 180;
            }
            if (text7.Text == "03:15")
            {
                myp_yaz = 195;
            }
            if (text7.Text == "03:30")
            {
                myp_yaz = 210;
            }
            if (text7.Text == "03:45")
            {
                myp_yaz = 225;
            }
            if (text7.Text == "04:00")
            {
                myp_yaz = 240;
            }
            if (text7.Text == "04:15")
            {
                myp_yaz = 255;
            }
            if (text7.Text == "04:30")
            {
                myp_yaz = 270;
            }
            if (text7.Text == "04:45")
            {
                myp_yaz = 285;
            }
            if (text7.Text == "05:00")
            {
                myp_yaz = 300;
            }
            //
            if (text8.Text == "00:05")
            {
                yp_vk_yaz = 5;
            }
            if (text8.Text == "00:10")
            {
                yp_vk_yaz = 10;
            }
            if (text8.Text == "00:15")
            {
                yp_vk_yaz = 15;
            }
            if (text8.Text == "00:20")
            {
                yp_vk_yaz = 20;
            }
            if (text8.Text == "00:25")
            {
                yp_vk_yaz = 25;
            }
            if (text8.Text == "00:30")
            {
                yp_vk_yaz = 30;
            }
            if (text8.Text == "00:35")
            {
                yp_vk_yaz = 35;
            }
            if (text8.Text == "00:40")
            {
                yp_vk_yaz = 40;
            }
            if (text8.Text == "00:45")
            {
                yp_vk_yaz = 45;
            }
            if (text8.Text == "00:50")
            {
                yp_vk_yaz = 50;
            }
            if (text8.Text == "00:55")
            {
                yp_vk_yaz = 55;
            }
            if (text8.Text == "01:00")
            {
                yp_vk_yaz = 60;
            }
            if (text8.Text == "01:05")
            {
                yp_vk_yaz = 65;
            }
            if (text8.Text == "01:10")
            {
                yp_vk_yaz = 70;
            }
            if (text8.Text == "01:15")
            {
                yp_vk_yaz = 75;
            }
            if (text8.Text == "01:20")
            {
                yp_vk_yaz = 80;
            }
            if (text8.Text == "01:25")
            {
                yp_vk_yaz = 85;
            }
            if (text8.Text == "01:30")
            {
                yp_vk_yaz = 90;
            }
            if (text8.Text == "01:35")
            {
                yp_vk_yaz = 95;
            }
            if (text8.Text == "01:40")
            {
                yp_vk_yaz = 100;
            }
            if (text8.Text == "01:45")
            {
                yp_vk_yaz = 105;
            }
            if (text8.Text == "01:50")
            {
                yp_vk_yaz = 110;
            }
            if (text8.Text == "01:55")
            {
                yp_vk_yaz = 115;
            }
            if (text8.Text == "02:00")
            {
                yp_vk_yaz = 120;
            }
            if (text8.Text == "02:15")
            {
                yp_vk_yaz = 135;
            }
            if (text8.Text == "02:30")
            {
                yp_vk_yaz = 150;
            }
            if (text8.Text == "02:45")
            {
                yp_vk_yaz = 165;
            }
            if (text8.Text == "03:00")
            {
                yp_vk_yaz = 180;
            }
            if (text8.Text == "03:15")
            {
                yp_vk_yaz = 195;
            }
            if (text8.Text == "03:30")
            {
                yp_vk_yaz = 210;
            }
            if (text8.Text == "03:45")
            {
                yp_vk_yaz = 225;
            }
            if (text8.Text == "04:00")
            {
                yp_vk_yaz = 240;
            }
            if (text8.Text == "04:15")
            {
                yp_vk_yaz = 255;
            }
            if (text8.Text == "04:30")
            {
                yp_vk_yaz = 270;
            }
            if (text8.Text == "04:45")
            {
                yp_vk_yaz = 285;
            }
            if (text8.Text == "05:00")
            {
                yp_vk_yaz = 300;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (combo1 != 1 || combo2 != 1 || combo3 != 1 || combo4 != 1 || combo5 != 1)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz");
            }
            else
            {
                kontrol1 = 1;
            }
            if (text1.Text == "0" && text2.Text == "0" && text3.Text == "0" && text4.Text == "0" || text5.Text == "0" && text6.Text == "0" && text7.Text == "0" && text8.Text == "0")
            {
                MessageBox.Show("Lütfen Uçuş Adedi ve Süresini Seçiniz");
            }
            else
            {
                kontrol2 = 1;
            }
            if (textBox9.Text.Trim() == "" || textBox10.Text.Trim() == "" || textBox11.Text.Trim() == "" || textBox12.Text.Trim() == "" || textBox13.Text.Trim() == "" || textBox14.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz");
            }
            else
            {
                kontrol4 = 1;
            }
            if (kontrol1 == 1 && kontrol2 == 1 && kontrol4 == 1)
            {
                if (t1 != 0 && t5 != 0 || t2 != 0 && t6 != 0 || t3 != 0 && t7 != 0 || t4 != 0 && t8 != 0)
                {
                    button1.Enabled = false;
                    timer1.Start();

                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo1 = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo2 = 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo3 = 1;
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo4 = 1;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo5 = 1;
        }
        void tire()
        {
            text1.Enabled = true;
            text2.Enabled = true;
            text3.Enabled = true;
            text4.Enabled = true;
            text5.Enabled = true;
            text6.Enabled = true;
            text7.Enabled = true;
            text8.Enabled = true;
            text1.Text = "0";
            text2.Text = "0";
            text3.Text = "0";
            text4.Text = "0";
            text5.Text = "0";
            text6.Text = "0";
            text7.Text = "0";
            text8.Text = "0";
        }
        private void text5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol5 == 1)
            {


                if (text5.Text == "0")
                {

                    t5 = 0;
                    tire();
                }
                else
                {
                    t5 = 1;
                    t3 = 0;
                    t2 = 0;
                    t4 = 0;
                    t6 = 0;
                    t7 = 0;
                    t8 = 0;
                    text2.Enabled = false;
                    text3.Enabled = false;
                    text4.Enabled = false;
                    text6.Enabled = false;
                    text7.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }
        private void text2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol2 == 1)
            {

                if (text2.Text == "0")
                {
                    tire();
                    t2 = 0;
                }
                else
                {
                    t2 = 1;
                    t1 = 0;
                    t4 = 0;
                    t7 = 0;
                    t3 = 0;
                    t5 = 0;
                    t8 = 0;
                    text1.Enabled = false;
                    text3.Enabled = false;
                    text4.Enabled = false;
                    text5.Enabled = false;
                    text7.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }

        private void text6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol6 == 1)
            {


                if (text6.Text == "0")
                {
                    t6 = 0;
                    tire();
                }
                else
                {
                    t6 = 1;
                    t3 = 0;
                    t1 = 0;
                    t4 = 0;
                    t5 = 0;
                    t7 = 0;
                    t8 = 0;
                    text1.Enabled = false;
                    text3.Enabled = false;
                    text4.Enabled = false;
                    text5.Enabled = false;
                    text7.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }

        private void text3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol3 == 1)
            {


                if (text3.Text == "0")
                {
                    tire();
                    t3 = 0;
                }
                else
                {
                    t3 = 1;
                    t1 = 0;
                    t2 = 0;
                    t4 = 0;
                    t5 = 0;
                    t6 = 0;
                    t8 = 0;
                    text1.Enabled = false;
                    text2.Enabled = false;
                    text4.Enabled = false;
                    text5.Enabled = false;
                    text6.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }

        private void text7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol7 == 1)
            {


                if (text7.Text == "0")
                {
                    t7 = 0;
                    tire();
                }
                else
                {
                    t7 = 1;
                    t1 = 0;
                    t2 = 0;
                    t4 = 0;
                    t5 = 0;
                    t6 = 0;
                    t8 = 0;
                    text1.Enabled = false;
                    text2.Enabled = false;
                    text4.Enabled = false;
                    text5.Enabled = false;
                    text6.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }

        private void text4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol4 == 1)
            {


                if (text4.Text == "0")
                {
                    t4 = 0;
                    tire();
                }
                else
                {
                    t3 = 0;
                    t1 = 0;
                    t2 = 0;
                    t4 = 1;
                    t5 = 0;
                    t6 = 0;
                    t7 = 0;
                    text1.Enabled = false;
                    text2.Enabled = false;
                    text3.Enabled = false;
                    text5.Enabled = false;
                    text6.Enabled = false;
                    text7.Enabled = false;
                }
            }
        }

        private void text8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol8 == 1)
            {
                if (text8.Text == "0")
                {
                    t8 = 0;
                    tire();
                }
                else
                {
                    t8 = 1;
                    t3 = 0;
                    t1 = 0;
                    t2 = 0;
                    t5 = 0;
                    t6 = 0;
                    t7 = 0;
                    text1.Enabled = false;
                    text2.Enabled = false;
                    text3.Enabled = false;
                    text5.Enabled = false;
                    text6.Enabled = false;
                    text7.Enabled = false;
                }
            }
        }
        private void kayitEkle_Load(object sender, EventArgs e)
        {
            //timer5.Start();
            timer4.Start();
            text_kontrol1 = 0;
            text_kontrol2 = 0;
            text_kontrol3 = 0;
            text_kontrol4 = 0;
            text_kontrol5 = 0;
            text_kontrol6 = 0;
            text_kontrol7 = 0;
            text_kontrol8 = 0;
            button2.Visible = false;
            button3.Visible = false;
            if (guncelle == 1)
            {
                button3.Visible = true;
                button2.Visible = true;
                button1.Visible = false;
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "select * from tablo where ucus_no='" + ucus_kayıt_no + "'";
                dr = sorgu.ExecuteReader();
                dr.Read();
                dateTimePicker1.Text = dr[1].ToString();
                comboBox1.Text = dr[2].ToString();
                comboBox2.Text = dr[3].ToString();
                text1.Text = dr[4].ToString();
                text2.Text = dr[5].ToString();
                text3.Text = dr[6].ToString();
                text4.Text = dr[7].ToString();
                text5.Text = dr[9].ToString();
                text6.Text = dr[10].ToString();
                text7.Text = dr[11].ToString();
                text8.Text = dr[12].ToString();
                textBox9.Text = dr[13].ToString();
                metre1 = dr[14].ToString();
                textBox11.Text = dr[15].ToString();
                comboBox3.Text = dr[16].ToString();
                metre2 = dr[17].ToString();
                metre3 = dr[18].ToString();
                textBox14.Text = dr[19].ToString();
                comboBox4.Text = dr[20].ToString();
                comboBox5.Text = dr[21].ToString();
                textBox15.Text = dr[22].ToString();
                for (int i = 0; i < metre1.Length; i++)
                {
                    if (metre1.Substring(i, 1) != "M")
                    {
                        textBox10.Text = textBox10.Text + metre1.Substring(i, 1);
                    }
                }
                for (int i = 0; i < metre3.Length; i++)
                {
                    if (metre3.Substring(i, 1) != "M")
                    {
                        textBox13.Text = textBox13.Text + metre3.Substring(i, 1);
                    }

                }
                for (int i = 0; i < metre2.Length; i++)
                {
                    if (metre2.Substring(i, 1) != "M")
                    {
                        textBox12.Text = textBox12.Text + metre2.Substring(i, 1);
                    }
                }
            }
            else
            {
                text1.Text = "0";
                text2.Text = "0";
                text3.Text = "0";
                text4.Text = "0";
                text5.Text = "0";
                text6.Text = "0";
                text7.Text = "0";
                text8.Text = "0";
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "select max(ucus_no) from tablo";
                dr = sorgu.ExecuteReader();
                dr.Read();
                try
                {
                    ucus = Convert.ToInt32(dr[0]) + 1;
                }
                catch (InvalidCastException)
                {
                    ucus = 1;
                }
                finally
                {
                    baglan.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            timer2.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı Silmek İstediğinize Emin misiniz?", "Kayıt Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                timer3.Start();
            }
        }

        private void kayitEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucus_kayit frm = new ucus_kayit();
            frm.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            aaa1 += 1;
            if (aaa1 >= 2)
            {
                timer1.Stop();
                duzelt();
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "insert into tablo2(ucus_no,yp_saat,typ_saat,myp_saat,yp_vk_saat) values('" + ucus + "','" + yp_yaz + "','" + typ_yaz + "','" + myp_yaz + "','" + yp_vk_yaz + "')";
                sorgu.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "insert into tablo(ucus_no,tarih,ucus_tipi,parasut_tipi,yp,typ,myp,yp_vk,yp_2,typ_2,myp_2,yp_vk_2,kalkis_yeri,yuksekligi,inis_yeri,cikis_turu,irtifa_kazanma,ucus_mesafesi,hava_durumu,ruzgar_yonu,ruzgar_hizi,dusunceler) values('" + ucus + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + text1.Text + "','" + text2.Text + "','" + text3.Text + "','" + text4.Text + "','" + text5.Text + "','" + text6.Text + "','" + text7.Text + "','" + text8.Text + "','" + textBox9.Text + "','" + textBox10.Text + " " + label14.Text + "','" + textBox11.Text + "','" + comboBox3.Text + "','" + textBox12.Text + " " + label17.Text + "','" + textBox13.Text + " " + label19.Text + "','" + textBox14.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox15.Text + "')";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı");
                this.Hide();
                ucus_kayit frm = new ucus_kayit();
                frm.Show();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            aaa2 += 1;
            if (aaa2 >= 2)
            {
                timer2.Stop();
                duzelt();
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "update tablo set tarih='" + dateTimePicker1.Text + "',ucus_tipi='" + comboBox1.Text + "',parasut_tipi='" + comboBox2.Text + "',yp='" + text1.Text + "',typ='" + text2.Text + "',myp='" + text3.Text + "',yp_vk='" + text4.Text + "',yp_2='" + text5.Text + "',typ_2='" + text6.Text + "',myp_2='" + text7.Text + "',yp_vk_2='" + text8.Text + "',kalkis_yeri='" + textBox9.Text + "',yuksekligi='" + textBox10.Text + "',inis_yeri='" + textBox11.Text + "',cikis_turu='" + comboBox3.Text + "',irtifa_kazanma='" + textBox12.Text + "',ucus_mesafesi='" + textBox13.Text + "',hava_durumu='" + textBox14.Text + "',ruzgar_yonu='" + comboBox4.Text + "',ruzgar_hizi='" + comboBox5.Text + "',dusunceler='" + textBox15.Text + "' where ucus_no='" + ucus_kayıt_no + "'";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "update tablo2 set yp_saat='" + yp_yaz + "',typ_saat='" + typ_yaz + "',myp_saat='" + myp_yaz + "',yp_vk_saat='" + yp_vk_yaz + "' where ucus_no='" + ucus_kayıt_no + "'";
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi");
                this.Hide();
                ucus_kayıt_no = 0;
                guncelle = 0;
                ucus_kayit frm = new ucus_kayit();
                frm.Show();

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            aaa3 += 1;
            if (aaa3 >= 2)
            {
                timer3.Stop();
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "delete * from tablo where ucus_no='" + ucus_kayıt_no + "'";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "delete * from tablo2 where ucus_no='" + ucus_kayıt_no + "'";
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
                this.Hide();
                ucus_kayıt_no = 0;
                guncelle = 0;
                ucus_kayit frm = new ucus_kayit();
                frm.Show();
            }

        }

        private void text1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text_kontrol1 == 1)
            {
                if (text1.Text == "0")
                {
                    tire();
                    t1 = 0;
                }
                else
                {
                    t1 = 1;
                    t2 = 0;
                    t3 = 0;
                    t4 = 0;
                    t6 = 0;
                    t7 = 0;
                    t8 = 0;
                    text2.Enabled = false;
                    text3.Enabled = false;
                    text4.Enabled = false;
                    text6.Enabled = false;
                    text7.Enabled = false;
                    text8.Enabled = false;
                }
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            if (sayac >= 2) 
            {
                this.Opacity = 100;
                timer4.Stop();
            }
            if (text1.Text == "1" || text1.Text == "2" || text1.Text == "3" || text1.Text == "4" || text1.Text == "5" || text1.Text == "6" || text1.Text == "7" || text1.Text == "8" || text1.Text == "9" || text1.Text == "10")
            {
                text2.Enabled = false;
                text3.Enabled = false;
                text4.Enabled = false;
                text6.Enabled = false;
                text7.Enabled = false;
                text8.Enabled = false;
            }
            if (text5.Text == "1" || text5.Text == "2" || text5.Text == "3" || text5.Text == "4" || text5.Text == "5" || text5.Text == "6" || text5.Text == "7" || text5.Text == "8" || text5.Text == "9" || text5.Text == "10")
            {
                text2.Enabled = false;
                text3.Enabled = false;
                text4.Enabled = false;
                text6.Enabled = false;
                text7.Enabled = false;
                text8.Enabled = false;
            }
            if (text2.Text == "1" || text2.Text == "2" || text2.Text == "3" || text2.Text == "4" || text2.Text == "5" || text2.Text == "6" || text2.Text == "7" || text2.Text == "8" || text2.Text == "9" || text2.Text == "10")
            {
                text1.Enabled = false;
                text3.Enabled = false;
                text4.Enabled = false;
                text5.Enabled = false;
                text7.Enabled = false;
                text8.Enabled = false;
            }
            if (text6.Text == "1" || text6.Text == "2" || text6.Text == "3" || text6.Text == "4" || text6.Text == "5" || text6.Text == "6" || text6.Text == "7" || text6.Text == "8" || text6.Text == "9" || text6.Text == "10")
            {
                text1.Enabled = false;
                text3.Enabled = false;
                text4.Enabled = false;
                text5.Enabled = false;
                text7.Enabled = false;
                text8.Enabled = false;
            }
            if (text3.Text == "1" || text3.Text == "2" || text3.Text == "3" || text3.Text == "4" || text3.Text == "5" || text3.Text == "6" || text3.Text == "7" || text3.Text == "8" || text3.Text == "9" || text3.Text == "10")
            {
                text1.Enabled = false;
                text2.Enabled = false;
                text4.Enabled = false;
                text5.Enabled = false;
                text6.Enabled = false;
                text8.Enabled = false;
            }
            if (text7.Text == "1" || text7.Text == "2" || text7.Text == "3" || text7.Text == "4" || text7.Text == "5" || text7.Text == "6" || text7.Text == "7" || text7.Text == "8" || text7.Text == "9" || text7.Text == "10")
            {
                text1.Enabled = false;
                text2.Enabled = false;
                text4.Enabled = false;
                text5.Enabled = false;
                text6.Enabled = false;
                text8.Enabled = false;
            }
            if (text4.Text == "1" || text4.Text == "2" || text4.Text == "3" || text4.Text == "4" || text4.Text == "5" || text4.Text == "6" || text4.Text == "7" || text4.Text == "8" || text4.Text == "9" || text4.Text == "10")
            {
                text1.Enabled = false;
                text2.Enabled = false;
                text3.Enabled = false;
                text5.Enabled = false;
                text6.Enabled = false;
                text7.Enabled = false;
            }
            if (text8.Text == "1" || text8.Text == "2" || text8.Text == "3" || text8.Text == "4" || text8.Text == "5" || text8.Text == "6" || text8.Text == "7" || text8.Text == "8" || text8.Text == "9" || text8.Text == "10")
            {
                text1.Enabled = false;
                text2.Enabled = false;
                text3.Enabled = false;
                text5.Enabled = false;
                text6.Enabled = false;
                text7.Enabled = false;
            }
            text_kontrol1 = 1;
            text_kontrol2 = 1;
            text_kontrol3 = 1;
            text_kontrol4 = 1;
            text_kontrol5 = 1;
            text_kontrol6 = 1;
            text_kontrol7 = 1;
            text_kontrol8 = 1;
        }

    }

}

