using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_Project
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
           // SqlDataReader dr;
            string sqlString="";
            //string newUserNo="";
            //con.Open();
            //sqlString = "SELECT u_no FROM Users ORDER BY u_no DESC ";
            //cmd = new SqlCommand(sqlString, con);
            //dr = cmd.ExecuteReader();
            //dr.Read();
            //newUserNo = dr[0].ToString();
            if (emailTextBox.Text.Length > 5 &&
                yourNameTextBox.Text.Length > 2 &&
                passwordTextBox.Text.Length > 7 &&
                passwordTextBox.Text == rePasswordTextBox.Text)
            {
                try
                {
                    con.Open();
                    sqlString = "INSERT INTO Users (u_no,name,email,pass,IsAdmin) " +
                      "VALUES(@u_no,@name,@email,@pass,@IsAdmin)";
                    cmd = new SqlCommand(sqlString, con);

                    cmd.Parameters.AddWithValue("@u_no", userNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@name", yourNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                    cmd.Parameters.AddWithValue("@IsAdmin", false);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succesfull!!");
                    this.Close();

                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message.ToString() + "Error!");
                }
                finally
                {

                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Check your enteries!!");
            }
        }
    }
}
