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
    public partial class ChoiceForm : Form
    {
        public string onlineUserNo;
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void ChoiceForm_Load(object sender, EventArgs e)
        {
            
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            connnectDb.Open();
            string sqlString = "Select * FROM Users Where userNo=@userNo";
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlCommand.Parameters.AddWithValue("@userNo", onlineUserNo);

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
                userNameLabel.Text += onlineUser.getName();
            }

           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {         
            Application.Exit();
        }

        private void questionAdviceButton_Click(object sender, EventArgs e)
        {
            QuestionAdviceForm questionAdviceForm = new QuestionAdviceForm();
            questionAdviceForm.onlineUserNo = onlineUserNo;
            questionAdviceForm.ShowDialog();
        }

        private void algorithmButton_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.gameType = "0";        //İndex of Algorithm
            gamePlayForm.onlineUserNo = onlineUserNo;
            gamePlayForm.ShowDialog();
        }

        private void objectOrientedButton_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.gameType = "1";        //İndex of ObjectOrientedProgramming
            gamePlayForm.onlineUserNo = onlineUserNo;
            gamePlayForm.ShowDialog();
        }

        private void softwareEngineeringButton_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.gameType = "2";        //İndex of SowftwareEngineering
            gamePlayForm.onlineUserNo = onlineUserNo;
            gamePlayForm.ShowDialog();
        }

        private void mixedButton_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.gameType = "3";        //İndex of Mixed Game
            gamePlayForm.onlineUserNo = onlineUserNo;
            gamePlayForm.ShowDialog();
        }

        private void scoreListButton_Click(object sender, EventArgs e)
        {
            ScoreListForm scoreListForm = new ScoreListForm();
            scoreListForm.onlineUserNo = onlineUserNo;
            scoreListForm.ShowDialog();
        }
    }
}
