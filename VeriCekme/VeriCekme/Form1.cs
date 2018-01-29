using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace VeriCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = "http://www.meb.gov.tr";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenbilgiler.ReadToEnd();
            int baslikbaslangic = gelen.IndexOf("<title>")+ 7;
            int baslıkbitisi = gelen.Substring(baslikbaslangic).IndexOf("</title>");
            string baslik = gelen.Substring(baslikbaslangic, baslıkbitisi);
            MessageBox.Show(baslik);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
