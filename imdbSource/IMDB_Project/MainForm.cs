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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //DetailsHumanForm detailHuman = new DetailsHumanForm();
           // detailHuman.MdiParent = this;
            form1.MdiParent = this;
            form1.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            form1.WindowState = FormWindowState.Maximized;
        }

        //private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}
    }
}
