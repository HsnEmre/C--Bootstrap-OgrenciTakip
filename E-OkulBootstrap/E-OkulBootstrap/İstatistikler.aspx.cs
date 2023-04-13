using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DataTable1TableAdapter dt = new DataSet1TableAdapters.DataTable1TableAdapter();
            txtbx1.Text = "Toplam Öğrenci Sayısı: " + dt.Istatistik1().ToString();
            txtbx2.Text="Toplam Öğretmen Sayısı: "+dt.Istatistik2().ToString();
            txtbx3.Text="Toplam Ders Sayısı: "+dt.Istatistik3().ToString();
            TextBox4.Text="Matematik Sınav1 En Yüksek Not Alan Öğrenci : "+dt.Istatistik4().ToString();
            TextBox5.Text= "Fizik Sınav1 En Yüksek Not Alan Öğrenci: "+dt.Istatistik5().ToString();
            TextBox6.Text= "Dil Anlatım Sınav1 En Yüksek Not Alan Öğrenci: "+dt.Istatistik6().ToString();
            TextBox7.Text= "Edebiyat Sınav1 En Yüksek Not Alan Öğrenci: "+dt.Istatistik7().ToString();
            TextBox8.Text= "Matematik dersi 1. sınav ortalaması: "+dt.Istatistik7().ToString();
            TextBox9.Text= "Fizik dersi 1. sınav ortalaması: "+dt.Istatistik9().ToString();
            TextBox10.Text= "Edebiyat dersi 1. sınav ortalaması : "+dt.Istatistik10().ToString();
            TextBox11.Text= "Matematik dersi geçen öğrenci sayısı: "+dt.Istatistik11().ToString();
            TextBox12.Text= "Matematik dersinden kalan öğrenci sayısı: "+dt.Istatistik12().ToString();





        }
    }
}