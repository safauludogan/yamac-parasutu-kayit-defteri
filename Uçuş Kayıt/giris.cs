using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
namespace Uçuş_Kayıt
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Uçus Kayit Defteri Veri Tabani\\ucusKayitDefteri.accdb'");
        OleDbCommand sorgu = new OleDbCommand();
        DataSet al = new DataSet();
        DataView goster = new DataView();
        OleDbDataReader dr;
        string sifreGirildimi, kul, sif, girildi, text5,cek,cek2;
        int sayac, sayac2, j;
        private void giris_Load(object sender, EventArgs e)
        {
            label13.Visible = false;
            Mutex Mtx = new Mutex(false, "SINGLE_INSTANCE_APP_MUTEX");
            if (Mtx.WaitOne(0, false) == false)
            {

                Mtx.Close();

                Mtx = null;

                MessageBox.Show("Program Zaten Açık");

                //Application.Exit();

            }
            else
            {
                this.Opacity = 100;
            }
            cekbox1();
            cekbox2();
            cekbox3();
            try
            {              
                    baglan.Close();
                    baglan.Open();
                    sorgu.Connection = baglan;
                    sorgu.CommandText = "select * from giriskismi";
                    dr = sorgu.ExecuteReader();
                    dr.Read();
                    text5 = dr[1].ToString();
                    cek2 = dr[6].ToString();
                    baglan.Close();

                    if (cek2 == "a")
                    {
                        checkBox4.Checked = true;
                        textBox5.Text = text5;
                    }
                    else
                    {
                        checkBox4.Checked = false;
                        textBox5.Text = "";
                    }


                    timer1.Start();
                    baglan.Close();
                    baglan.Open();
                    sorgu.Connection = baglan;
                    sorgu.CommandText = "select * from giriskismi";
                    dr = sorgu.ExecuteReader();
                    dr.Read();
                    sifreGirildimi = dr[0].ToString();
                    kul = dr[1].ToString();
                    sif = dr[2].ToString();
                    baglan.Close();
                    if (sifreGirildimi != "a")
                    {
                        button4.Visible = false;
                    }

                }

            
            catch
            {
                if (sifreGirildimi != "a")
                {
                    try
                    {
                        button7.Visible = false;
                        button3.Visible = false;
                        girildi = "b";
                        baglan.Close();
                        baglan.Open();
                        sorgu.Connection = baglan;
                        sorgu.CommandText = "update  giriskismi set sifre_girildi='" + girildi + "'";
                        sorgu.ExecuteNonQuery();
                        baglan.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Office Programlarının Yüklü Olması Gerekiyor");
                        Application.Exit();
                    }
                }
            }

            if (sifreGirildimi == "a")
            {
                button7.Visible = true;
                button3.Visible = true;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox2.Location = new Point(25, 85);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text.ToUpper();
            textBox11.Text = textBox11.Text.ToUpper();
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                sayac += 1;
            }
            if (sayac < 5)
            {
                MessageBox.Show("Lütfen Kullanıcı adını en az 5 harftan oluşacak şekilde yazınız");
                sayac = 0;
            }
            else if (textBox2.Text == "" || textBox3.Text == "" || textBox10.Text==""||textBox11.Text=="")
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
            else
            {
                MessageBox.Show("Kullanıcı Oluşturuldu");
                sifreGirildimi = "a";
                baglan.Close();
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "insert into giriskismi(sifre_girildi,kullanici,sifre,ad,soyad,d_t) values('" + sifreGirildimi + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + dateTimePicker1.Text + "')";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                ucus_kayit frm = new ucus_kayit();
                frm.Show();
                this.Hide();
            }
        }
        void cekbox1()
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Şifreyi Gizle";
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';

            }
            else
            {
                checkBox1.Text = "Şifreyi Göster";
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cekbox1();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                cek = "a";
                textBox5.Text = text5;
                yazdir();
            }
            else
            {
                cek = "b";
                
                yazdir();
            }
            if (textBox5.Text == kul && textBox6.Text == sif)
            {
                MessageBox.Show("Giriş Başarılı");
                ucus_kayit frm = new ucus_kayit();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre yanlış");
            }
        }
        void cekbox2()
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Text = "Şifreyi Gizle";
                textBox6.PasswordChar = '\0';


            }
            else
            {
                checkBox2.Text = "Şifreyi Göster";
                textBox6.PasswordChar = '*';
            }
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            cekbox2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            button7.Visible = false;
            textBox4.Visible = true;
            button5.Visible = true;
            button3.Visible = false;
        }
        void cekbox3()
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Text = "Şifreyi Gizle";
                textBox8.PasswordChar = '\0';
                textBox9.PasswordChar = '\0';

            }
            else
            {
                checkBox3.Text = "Şifreyi Göster";
                textBox8.PasswordChar = '*';
                textBox9.PasswordChar = '*';
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cekbox3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = textBox7.Text.Trim();
            textBox8.Text = textBox8.Text.Trim();
            textBox9.Text = textBox9.Text.Trim();
            for (j = 0; j < textBox7.Text.Length; j++)
            {
                sayac2 += 1;
            }
            if (sayac2 < 5)
            {
                MessageBox.Show("Lütfen Kullanıcı adını en az 5 harftan oluşacak şekilde yazınız");
                sayac2 = 0;
            }
            else
            {
                if (textBox8.Text != textBox9.Text)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
                else
                {
                    if (textBox9.Text == "" || textBox8.Text == "")
                    {
                        MessageBox.Show("Lütfen Şifrenizi Giriniz");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Yenilendi");
                        baglan.Open();
                        sorgu.Connection = baglan;
                        sorgu.CommandText = "update giriskismi set kullanici='" + textBox7.Text + "',sifre='" + textBox8.Text + "'";
                        sorgu.ExecuteNonQuery();
                        baglan.Close();
                        ucus_kayit frm = new ucus_kayit();
                        frm.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "kbh07kjp02")
            {
                textBox4.Visible = false;
                groupBox3.Visible = true;
                groupBox2.Visible = true;
                button5.Visible = false;
                groupBox3.Location = new Point(25, 85);
            }
            else
            {
                MessageBox.Show("Doğrulama kodu yanlış");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Location = new Point(900, 900);
            groupBox3.Visible = false;
            button3.Visible = true;
            button7.Visible = true;
            groupBox2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Bilgileri Güncelleme";
            label2.Visible = true;
            button9.Visible = true;
            groupBox1.Location = new Point(25, 85);
            groupBox1.Width = 311;
            groupBox1.Height = 201;
            button8.Visible = true;
            label1.Visible = false;
           
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Location = new Point(151, 123);
            label2.Location = new Point(33, 126);
            textBox3.Visible = false;
            button7.Visible = false;
            groupBox2.Location = new Point(900, 20);
            groupBox3.Location = new Point(300, 20);
            groupBox1.Visible = true;
            button3.Visible = false;
            button5.Visible = false;
            textBox4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text.ToUpper();
            textBox11.Text = textBox11.Text.ToUpper();
            textBox10.Text = textBox10.Text.Trim();
            textBox11.Text = textBox11.Text.Trim();
            if (textBox2.Text==sif)
            {
                if (textBox10.Text == "" || textBox11.Text == "")
                {
                    MessageBox.Show("Lütfen Adınızı ve Soyadınızı yazınız");
                }
                else
                {
                    MessageBox.Show("Bilgiler Güncellendi");
                    baglan.Open();
                    sorgu.Connection = baglan;
                    sorgu.CommandText = "update giriskismi set ad='" + textBox10.Text + "',soyad='" + textBox11.Text + "',d_t='" + dateTimePicker1.Text + "'"; 
                    sorgu.ExecuteNonQuery();
                    baglan.Close();
                    giris frm = new giris();
                    frm.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Yanlış Şifre");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            Hide();
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void yazdir()
        {
            baglan.Close();
            baglan.Open();
            sorgu.Connection = baglan;
            sorgu.CommandText = "update  giriskismi set cek_tikli='" + cek + "'";
            sorgu.ExecuteNonQuery();
            baglan.Close();
        }
    }
}