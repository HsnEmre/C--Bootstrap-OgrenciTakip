using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_OkulBootstrap
{
    public partial class Grafikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region chart1Kitap
            Chart1.Series["Kitap"].Points.AddXY("İstabul", 4);
            Chart1.Series["Kitap"].Points.AddXY("Ankara", 20);
            Chart1.Series["Kitap"].Points.AddXY("Bursa", 18);
            Chart1.Series["Kitap"].Points.AddXY("İzmir", 35);
            Chart1.Series["Kitap"].Points.AddXY("Konya", 3);
            #endregion




            #region char2Nufus
            Chart2.Series["Nüfus"].Points.AddXY("Andeniz", 4);
            Chart2.Series["Nüfus"].Points.AddXY("Marmara", 20);
            Chart2.Series["Nüfus"].Points.AddXY("Ege", 18);
            Chart2.Series["Nüfus"].Points.AddXY("Doğu Anadolu", 35);
            Chart2.Series["Nüfus"].Points.AddXY("Güney Doğu Anadolu", 33);
            Chart2.Series["Nüfus"].Points.AddXY("Kuzey Doğu Anadolu", 23);
            Chart2.Series["Nüfus"].Points.AddXY("Karadeniz", 12);
            Chart2.Series["Nüfus"].Points.AddXY("İç Anadolu", 53);
            #endregion



            #region chart3Dersler
            Chart3.Series["Dersler"].Points.AddXY("Fizik", 4);
            Chart3.Series["Dersler"].Points.AddXY("Kimya", 20);
            Chart3.Series["Dersler"].Points.AddXY("Matematik", 18);
            Chart3.Series["Dersler"].Points.AddXY("Türkçe", 35);
            Chart3.Series["Dersler"].Points.AddXY("Dil Anlatım", 33);
            Chart3.Series["Dersler"].Points.AddXY("Web Tasarım", 23);
            Chart3.Series["Dersler"].Points.AddXY("Algoritma", 12);
            Chart3.Series["Dersler"].Points.AddXY("Ayrık Yapılar", 53);
            #endregion


            #region chart4Öğretmenler
            Chart4.Series["Öğretmen"].Points.AddXY("Andeniz", 4);
            Chart4.Series["Öğretmen"].Points.AddXY("Marmara", 20);
            Chart4.Series["Öğretmen"].Points.AddXY("Ege", 18);
            Chart4.Series["Öğretmen"].Points.AddXY("Doğu Anadolu", 35);
            Chart4.Series["Öğretmen"].Points.AddXY("Güney Doğu Anadolu", 33);
            Chart4.Series["Öğretmen"].Points.AddXY("Kuzey Doğu Anadolu", 23);
            Chart4.Series["Öğretmen"].Points.AddXY("Karadeniz", 12);
            Chart4.Series["Öğretmen"].Points.AddXY("İç Anadolu", 53);
            #endregion
        }
    }
}