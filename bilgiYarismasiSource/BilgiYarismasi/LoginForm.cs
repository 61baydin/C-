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
    public partial class LoginForm : Form
    {
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void e(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.signInButton_Click(sender, e);

        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            try { connnectDb.Open(); } catch { MessageBox.Show("Check your connection!", "Error"); }
            try
            {
                string sqlString = "Select * FROM Users Where userNo=@userNo AND password=@password";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@userNo", userNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", passwordTextBox.Text);

                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                if (sqlDataReader.HasRows)
                {
                    User onlineUser = new User();
                    onlineUser.setUserValues(sqlDataReader[0].ToString(), 
                                                sqlDataReader[1].ToString(), 
                                                    sqlDataReader[2].ToString(),
                                                        sqlDataReader[3].ToString(),
                                                            Convert.ToBoolean(sqlDataReader[4].ToString()));
                    connnectDb.Close();
                    this.Hide();
                    ChoiceForm choiceForm = new ChoiceForm();
                    choiceForm.onlineUserNo = onlineUser.getUserNo();
                    choiceForm.ShowDialog();
                

                }
                else
                {
                    MessageBox.Show("Username or password incorrect.", "Error");
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message.ToString(), "Error");
            }
            finally
            {
                connnectDb.Close();
            }


        }

        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            signInButton.Select();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            passwordTextBox.UseSystemPasswordChar = true;   // yazarken şifre görünmemesi için 
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();

        }
       
    }
    
}
