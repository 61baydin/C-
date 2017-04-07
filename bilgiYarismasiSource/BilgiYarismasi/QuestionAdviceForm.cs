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
    public partial class QuestionAdviceForm : Form
    {
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public string onlineUserNo;
        public string questionLevel="1";//default value
        public string questionTime="15";//default value
        public string trueAnswer="A";//default value
        public QuestionAdviceForm()
        {
            InitializeComponent();
        }
        public void loadQuestionTopic()
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            try { connnectDb.Open(); } catch { MessageBox.Show("Check your connection!", "Error"); }

            string sqlString = "Select * FROM Topics WHERE topicNo < 3";        //topicNo < 3 because Mixed is not a type 
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                topicListBox.Items.Add(sqlDataReader[1].ToString());
            }
            connnectDb.Close();
        }

        private void QuestionAdviceForm_Load(object sender, EventArgs e)
        {
            questionDetailsPanel.Select();
            loadQuestionTopic();   
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendAdviceButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand;
            try { connnectDb.Open(); } catch { MessageBox.Show("Check your connection!", "Error"); }

            try
            {
                string sqlString = "INSERT INTO Questions (question,a,b,c,d,true,time,questionLevel,topicNo,isAccept,userNo) VALUES(@question,@a,@b,@c,@d,@true,@time,@questionLevel,@topicNo,@isAccept,@userNo)";
                sqlCommand = new SqlCommand(sqlString, connnectDb);

                sqlCommand.Parameters.AddWithValue("@question",questionTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@a", aTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@b", bTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@c", cTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@d", dTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@true", trueAnswer);
                sqlCommand.Parameters.AddWithValue("@time", questionTime);
                sqlCommand.Parameters.AddWithValue("@questionLevel",questionLevel);
                sqlCommand.Parameters.AddWithValue("@topicNo", topicListBox.SelectedIndex.ToString());      //topic nolar 0dan başlayarak indexli 
                sqlCommand.Parameters.AddWithValue("@isAccept", 0);             //Sorular ilk girildiğinde false olacak ve oyunda gösterilmeyecek admin Onayı ile true olcak
                sqlCommand.Parameters.AddWithValue("@userNo", onlineUserNo);        //Soruyu ekleyen kişinin user Nosu.

                sqlCommand.ExecuteNonQuery();
                connnectDb.Close();

                questionTextBox.Clear();
                aTextBox.Clear();
                bTextBox.Clear();
                cTextBox.Clear();
                dTextBox.Clear();
                topicListBox.SelectedIndex = 0;

                MessageBox.Show("Your recommendation is taken.","Thanks");
            }
            catch
            {
                MessageBox.Show("Check your entries.", "Error");
            }
            finally
            {
                connnectDb.Close();
            }
            
            

        }

        private void levelRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                questionLevel = levelRadioButton1.Text;
            
        }

        private void levelRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
                questionLevel = levelRadioButton2.Text;
            
        }

        private void levelRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
                questionLevel = levelRadioButton3.Text;
            
        }

        private void timeTrackBar_Scroll(object sender, EventArgs e)
        {
            secondLabel.Text = timeTrackBar.Value.ToString() + " Saniye";
            questionTime = timeTrackBar.Value.ToString();
        }

        private void aTrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trueAnswer = aTrueRadioButton.Text;
        }

        private void bTrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trueAnswer = bTrueRadioButton.Text;
        }

        private void cTrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trueAnswer = cTrueRadioButton.Text;
        }

        private void dTrueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            trueAnswer = dTrueRadioButton.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(questionLevel);
        }

        private void questionTextBox_Enter(object sender, EventArgs e)
        {
            questionTextBox.Clear();
        }

        private void aTextBox_Enter(object sender, EventArgs e)
        {
            aTextBox.Clear();
        }

       
        private void bTextBox_Enter(object sender, EventArgs e)
        {
            bTextBox.Clear();
        }

        private void cTextBox_Enter(object sender, EventArgs e)
        {
            cTextBox.Clear();
        }

        private void dTextBox_Enter(object sender, EventArgs e)
        {
            dTextBox.Clear();
        }
    }
}
