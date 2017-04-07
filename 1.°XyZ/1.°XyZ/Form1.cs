using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1._XyZ
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        double[,] a = new double[3,4];
      
        double fonk(double[,] det) 
        {
            double delta;
            delta = det[0, 0] * det[1, 1] * det[2, 2] + det[1, 0] * det[2, 1] * det[0, 2] + det[2, 0] * det[0, 1] * det[1, 2] - det[0, 2] * det[1, 1] * det[2, 0] - det[1, 2] * det[2, 1] * det[0, 0] - det[2, 2] * det[0, 1] * det[1, 0];
            return delta;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            a[0,0] = Convert.ToDouble(textBox1.Text);
            a[0,1] = Convert.ToDouble(textBox2.Text);
            a[0,2] = Convert.ToDouble(textBox3.Text);
            a[0,3] = Convert.ToDouble(textBox4.Text);
            a[1,0] = Convert.ToDouble(textBox5.Text);
            a[1,1] = Convert.ToDouble(textBox6.Text);
            a[1,2] = Convert.ToDouble(textBox7.Text);
            a[1,3] = Convert.ToDouble(textBox8.Text);
            a[2,0] = Convert.ToDouble(textBox9.Text);
            a[2,1] = Convert.ToDouble(textBox10.Text);
            a[2,2] = Convert.ToDouble(textBox11.Text);
            a[2,3] = Convert.ToDouble(textBox12.Text);

            double delta_a,delta_1,delta_2,delta_3;

           
            int i, j = 0;
            double[,] X_1= new double[3,3];
            double[,] X_2= new double[3,3];
            double[,] X_3= new double[3,3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    X_1[i,j] = a[i,j];            //x_1 e A matrisindeki değerler Aktarılır.
                    X_2[i,j] = a[i,j];            //x_2 e A matrisindeki değerler Aktarılır.
                    X_3[i,j] = a[i,j];            //x_3 e A matrisindeki değerler Aktarılır.
                }
            }

            for (i = 0; i < 3; i++)
            {
                X_1[i,0] = a[i,3];                //x_1 in 0 ıncı sütünuna a3 değerler Aktarılır.
                X_2[i,1] = a[i,3];                //x_2 in 1 inci sütünuna a3 değerler Aktarılır.
                X_3[i,2] = a[i,3];                //x_3 in 2 inci sütünuna a3 değerler Aktarılır.
            }
            delta_a = fonk(a);
            delta_1 = fonk(X_1) / delta_a;        //X_1 matris sonucunu A ya böl
            delta_2 = fonk(X_2) / delta_a;        //X_2 matris sonucunu A ya böl
            delta_3 = fonk(X_3) / delta_a;        //X_3 matris sonucunu A ya böl

            delta_1 = Math.Round(delta_1, 5);
            delta_2 = Math.Round(delta_2, 5);
            delta_3 = Math.Round(delta_3, 5);

            label11.Text ="x=  " + delta_1.ToString();
            label12.Text ="y=  " + delta_2.ToString();
            label13.Text ="z=  " + delta_3.ToString();

            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            }
            catch
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol ediniz!!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/61baydin");
        }
    }
}