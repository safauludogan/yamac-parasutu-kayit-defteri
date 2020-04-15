using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace Uçuş_Kayıt
{
    class classlar
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\\Uçus Kayit Defteri Veri Tabani\\ucusKayitDefteri.accdb'");
        string a, a2;
        public string top(string topla, int sayac)
        {
            if (sayac == 1) 
            {
                a = "select sum(yp) as toplam from tablo";
            }
            if (sayac == 2)
            {
                a = "select sum(typ) as toplam from tablo";
            }
            if (sayac == 3)
            {
                a = "select sum(myp) as toplam from tablo";
            }
            if (sayac == 4)
            {
                a = "select sum(yp_vk) as toplam from tablo";
            }
            baglan.Open();
            OleDbCommand komut = new OleDbCommand(a, baglan);
            topla = komut.ExecuteScalar().ToString();
            komut.ExecuteNonQuery();
            baglan.Close();
            return topla;
        }
        public string top2(string topla2, int sayac)
        {
            if (sayac == 1)
            {
                a2 = "select sum(yp_saat) as toplam from tablo2";
            }
            if (sayac == 2)
            {
                a2 = "select sum(typ_saat) as toplam from tablo2";
            }
            if (sayac == 3)
            {
                a2 = "select sum(myp_saat) as toplam from tablo2";
            }
            if (sayac == 4)
            {
                a2 = "select sum(yp_vk_saat) as toplam from tablo2";
            }
            baglan.Open();
            OleDbCommand komut = new OleDbCommand(a2, baglan);
            topla2 = komut.ExecuteScalar().ToString();
            komut.ExecuteNonQuery();
            baglan.Close();
            return topla2;
        }
       
    }
    
}
