using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCKimlikDogrulama.TCKNService;

namespace TCKimlikDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient proxy = new KPSPublicSoapClient();
            bool Dogrula = proxy.TCKimlikNoDogrula(Convert.ToInt64(txtPassword.Text),
                txtAd.Text.ToUpper(),txtSoyad.Text.ToUpper(),Convert.ToInt32(txtDogumYili.Text));
            MessageBox.Show(Dogrula.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtDogumYili.PasswordChar = '*';
        }
    }
}
