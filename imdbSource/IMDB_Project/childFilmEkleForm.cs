using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_Project
{
    public partial class childFilmEkleForm : Form
    {
        public childFilmEkleForm()
        {
            InitializeComponent();
        }

        private void childFilmEkleForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void childFilmEkleForm_Load(object sender, EventArgs e)
        {
            childOyuncuEkle choe = new childOyuncuEkle();
            choe.Close();
        }
    }
}
