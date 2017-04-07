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

namespace BilgiYarismasi
{
    public partial class SignUpForm : Form
    {
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            emailTextBox.Clear();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            passwordTextBox.UseSystemPasswordChar = true;
        }

      



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            signUpButton.Select(); // Textbox seçili gelmesin diye yapıldı textbox seçilince içini temizliyor.
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
              
            SqlCommand sqlCommand;
            try { connnectDb.Open(); } catch { MessageBox.Show("Check your connection!", "Error"); }
            try
            {
                string sqlString = "INSERT INTO Users (userNo,name,email,password,isAdmin) VALUES(@userNo,@name,@email,@password,0)";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@userNo", userNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@name", yourNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@email", emailTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);


                sqlCommand.ExecuteNonQuery();
                connnectDb.Close();
                MessageBox.Show("You have successfully registered.", "Congratulation");
                this.Close();
            }
            catch
            {
                 MessageBox.Show("Check your entries.","Error");
            }
            finally
            {
                connnectDb.Close();
            }



            }

        private void yourNameTextBox_Enter(object sender, EventArgs e)
        {
            yourNameTextBox.Clear();
        }
    }
}
