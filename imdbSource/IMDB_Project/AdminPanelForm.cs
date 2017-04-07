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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void filmEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            childFilmEkleForm chForm = new childFilmEkleForm();
            chForm.MdiParent = this;
            chForm.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            chForm.WindowState = FormWindowState.Maximized;
            
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childOyuncuEkle chOyuncuForm = new childOyuncuEkle();
            chOyuncuForm.MdiParent = this;
            chOyuncuForm.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            chOyuncuForm.WindowState = FormWindowState.Maximized;
        }
    }
}
