using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TCMBDovizKurları
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument dosya = new XmlDocument();
            dosya.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlNodeList items = dosya.SelectNodes("Tarih_Date/Currency");
            foreach (XmlNode item in items)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Kod"].Value =
                     item.Attributes["Kod"].InnerText;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Isim"].Value =
                    item.SelectSingleNode("Isim").InnerText;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Name"].Value =
                    item.SelectSingleNode("CurrencyName").InnerText;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Alis"].Value =
                    item.SelectSingleNode("ForexBuying").InnerText;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Satis"].Value =
                    item.SelectSingleNode("ForexSelling").InnerText;
            }
            DateTime tarih = Convert.ToDateTime(dosya.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            label2.Text = tarih.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/61baydin");
        }
    }
}
