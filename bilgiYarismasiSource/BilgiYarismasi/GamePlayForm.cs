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
    public partial class GamePlayForm : Form
    {
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public string onlineUserNo;
        public const int EASYQUESTIONLINE = 5;
        public const int MEDIUMQUESTIONLINE = 10;
        public const int HARDQUESTIONLINE = 15;
        public const int MAXIMUMQUESTIONCOUNT = 15;
        public const int MAXRANDOMVALUEFORWRONGANSWER = 25;

        public const int EASY = 1;
        public const int MEDIUM = 2;
        public const int HARD = 3;

        public string gameType = "";
        public int questionTime;
        public int questionCounter = 1;
        public int trueAnswerCount = 0 ;
        public double point;

     
        Question[] gameQuestions = new Question[MAXIMUMQUESTIONCOUNT + 1];

        public GamePlayForm()
        {
            InitializeComponent();
        }

        public void getQuestionFromDb()
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            string sqlString;

            //_______________________________________EASY__________________________________
            if (gameType == "3")        // İf game type is 3 (Mixed) then do not use game type
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", EASY);
            }
            else
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND topicNo=@gameType AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", EASY);
                sqlCommand.Parameters.AddWithValue("@gameType", gameType);
            }
            connnectDb.Open();
            sqlDataReader = sqlCommand.ExecuteReader();

            for (int i = 1; i <= EASYQUESTIONLINE; i++)
            {
                sqlDataReader.Read();
                gameQuestions[i] = new Question();

                //Set question object values from data base
                gameQuestions[i].setAllValues(sqlDataReader["questionNo"].ToString(), sqlDataReader["question"].ToString(),
                                        sqlDataReader["a"].ToString(), sqlDataReader["b"].ToString(),
                                        sqlDataReader["c"].ToString(), sqlDataReader["d"].ToString(),
                                        sqlDataReader["true"].ToString(), sqlDataReader["time"].ToString(),
                                        sqlDataReader["questionLevel"].ToString(), sqlDataReader["topicNo"].ToString());

            }

            connnectDb.Close();
            //_______________________________________MEDIUM__________________________________

            if (gameType == "3")        // İf game type is 3 (Mixed) then do not use game type
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", MEDIUM);
            }
            else
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND topicNo=@gameType AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", MEDIUM);
                sqlCommand.Parameters.AddWithValue("@gameType", gameType);
            }
            connnectDb.Open();
            sqlDataReader = sqlCommand.ExecuteReader();

            for (int i = EASYQUESTIONLINE + 1; i <= MEDIUMQUESTIONLINE; i++)
            {
                sqlDataReader.Read();
                gameQuestions[i] = new Question();

                //Set question object values from data base
                gameQuestions[i].setAllValues(sqlDataReader["questionNo"].ToString(), sqlDataReader["question"].ToString(),
                                        sqlDataReader["a"].ToString(), sqlDataReader["b"].ToString(),
                                        sqlDataReader["c"].ToString(), sqlDataReader["d"].ToString(),
                                        sqlDataReader["true"].ToString(), sqlDataReader["time"].ToString(),
                                        sqlDataReader["questionLevel"].ToString(), sqlDataReader["topicNo"].ToString());

            }

            connnectDb.Close();
            //_______________________________________HARD__________________________________

            if (gameType == "3")        // İf game type is 3 (Mixed) then do not use game type
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", HARD);
            }
            else
            {
                sqlString = "Select TOP 5 * FROM Questions Where questionLevel=@questionLevel AND topicNo=@gameType AND isAccept='True' ORDER BY NEWID()";
                sqlCommand = new SqlCommand(sqlString, connnectDb);
                sqlCommand.Parameters.AddWithValue("@questionLevel", HARD);
                sqlCommand.Parameters.AddWithValue("@gameType", gameType);
            }
            connnectDb.Open();
            sqlDataReader = sqlCommand.ExecuteReader();

            for (int i = MEDIUMQUESTIONLINE + 1; i <= HARDQUESTIONLINE; i++)
            {
                sqlDataReader.Read();
                gameQuestions[i] = new Question();

                //Set question object values from data base
                gameQuestions[i].setAllValues(sqlDataReader["questionNo"].ToString(), sqlDataReader["question"].ToString(),
                                        sqlDataReader["a"].ToString(), sqlDataReader["b"].ToString(),
                                        sqlDataReader["c"].ToString(), sqlDataReader["d"].ToString(),
                                        sqlDataReader["true"].ToString(), sqlDataReader["time"].ToString(),
                                        sqlDataReader["questionLevel"].ToString(), sqlDataReader["topicNo"].ToString());

            }

            connnectDb.Close();







        }
        public void loadQuestion(int questionCount)
        {
            if(questionCount > MAXIMUMQUESTIONCOUNT)    // Game is Finished
            {
                gamePlayPanel.Enabled = false;
                gamePlayPanel.Visible = false;
                questionTimer.Stop();
                pointPanel.Visible = true;
                point = (trueAnswerCount / Convert.ToDouble(MAXIMUMQUESTIONCOUNT)) * 100;     // For 100 point
                trueAnswerLabel.Text = trueAnswerCount.ToString();
                pointLabel.Text = point.ToString("N2");
            }
            else
            {
               if (questionCount == HARDQUESTIONLINE)
                {
                    nextQuestionButton.Text = "Finished Game >>";
                }

               //__________________________________________________________________
               //__________________________________________________________________
                //Load Quesion and choice to Buttons.
                questionLabel.Text = gameQuestions[questionCount].getQuestion();          
                choiceAButton.Text = gameQuestions[questionCount].getChoiceA();
                choiceBButton.Text = gameQuestions[questionCount].getChoiceB();
                choiceCButton.Text = gameQuestions[questionCount].getChoiceC();
                choiceDButton.Text = gameQuestions[questionCount].getChoiceD();


                questionCounterLabel.Text = questionCount.ToString() + " / " + MAXIMUMQUESTIONCOUNT.ToString();  // 15 is question count 

                questionTime = Convert.ToInt32(gameQuestions[questionCount].getTime());
                questionTimer.Start();
            }
        }
        public void showAudienceChart()
        {
            
            Random random = new Random();
            int choiceA = 0 , choiceB = 0 , choiceC = 0 , choiceD = 0 ;

            if (gameQuestions[questionCounter].getTrueAnswer() == "A")
            {
                choiceB = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceC = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceD = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceA = 100 - (choiceB + choiceC + choiceD);
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "B")
            {
                choiceA = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceC = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceD = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceB = 100 - (choiceA + choiceC + choiceD);
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "C")
            {
                choiceA = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceB = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceD = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceC = 100 - (choiceA + choiceB + choiceD);
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "D")
            {
                choiceA = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceB = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceC = random.Next(MAXRANDOMVALUEFORWRONGANSWER);
                choiceD = 100 - (choiceA + choiceB + choiceC);
            }
            
            audienceChart.Series["Audience"].Points.AddXY("A",choiceA);
            audienceChart.Series["Audience"].Points.AddXY("B",choiceB);
            audienceChart.Series["Audience"].Points.AddXY("C",choiceC);
            audienceChart.Series["Audience"].Points.AddXY("D",choiceD);

            audienceChart.Visible = true;

        }
        public void disableTwoWrongAnswer()
        {
            Random random = new Random();
            int randValue=random.Next(2);
            if(gameQuestions[questionCounter].getTrueAnswer() == "A")
            {
                switch (randValue)
                {
                    case 0:
                        choiceBButton.Enabled = false;
                        choiceCButton.Enabled = false;
                        break;
                    case 1:
                        choiceBButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                    case 2:
                        choiceCButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                }
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "B")
            {
                switch (randValue)
                {
                    case 0:
                        choiceAButton.Enabled = false;
                        choiceCButton.Enabled = false;
                        break;
                    case 1:
                        choiceAButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                    case 2:
                        choiceCButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                }
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "C")
            {
                switch (randValue)
                {
                    case 0:
                        choiceAButton.Enabled = false;
                        choiceBButton.Enabled = false;
                        break;
                    case 1:
                        choiceAButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                    case 2:
                        choiceBButton.Enabled = false;
                        choiceDButton.Enabled = false;
                        break;
                }
            }
            if (gameQuestions[questionCounter].getTrueAnswer() == "D")
            {
                switch (randValue)
                {
                    case 0:
                        choiceAButton.Enabled = false;
                        choiceBButton.Enabled = false;
                        break;
                    case 1:
                        choiceAButton.Enabled = false;
                        choiceCButton.Enabled = false;
                        break;
                    case 2:
                        choiceBButton.Enabled = false;
                        choiceCButton.Enabled = false;
                        break;
                }
            }

        }
        public void disableAllButtons()
        {
            choiceAButton.Enabled = false;
            choiceBButton.Enabled = false;
            choiceCButton.Enabled = false;
            choiceDButton.Enabled = false;
            fiftyFiftyButton.Enabled = false;
            getExtraTimeButton.Enabled = false;
            askAudienceButton.Enabled = false;
            audienceChart.Visible = false;

        }
        public void enableAllButtons()
        {
            choiceAButton.Enabled = true;
            choiceBButton.Enabled = true;
            choiceCButton.Enabled = true;
            choiceDButton.Enabled = true;
            fiftyFiftyButton.Enabled = true;
            getExtraTimeButton.Enabled = true;
            askAudienceButton.Enabled = true;

            timeOverLabel.Visible = false;
            // Default Button BackColor
            choiceAButton.BackColor = Color.FromArgb(40, 40, 40);
            choiceBButton.BackColor = Color.FromArgb(40, 40, 40);
            choiceCButton.BackColor = Color.FromArgb(40, 40, 40);
            choiceDButton.BackColor = Color.FromArgb(40, 40, 40);
        }
        
        private void startLabel_Click(object sender, EventArgs e)
        {
            startLabel.Visible = false;         
            gamePlayPanel.Visible = true;
            nextQuestionButton.Visible = true;
            getQuestionFromDb();                        // Veri tabanından soruları çek
            loadQuestion(questionCounter);            // ilk soruyu ekrana getir.

        }

        private void choiceAButton_Click(object sender, EventArgs e)
        {
            if (gameQuestions[questionCounter].getTrueAnswer() == "A")
            {
                disableAllButtons();
                questionTimer.Stop();
                choiceAButton.BackColor = Color.DarkGreen;      // cevap doğru ise yeşil olsun.
                trueAnswerCount++;
            }
            else
            {
                disableAllButtons();
                questionTimer.Stop();
                choiceAButton.BackColor = Color.DarkRed;      // cevap yanlış ise kırmızı olsun.

                //doğru cevabı göster
                if (gameQuestions[questionCounter].getTrueAnswer() == "B") choiceBButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "C") choiceCButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "D") choiceDButton.BackColor = Color.DarkGreen;
            }

        }

        private void choiceBButton_Click(object sender, EventArgs e)
        {
            if (gameQuestions[questionCounter].getTrueAnswer() == "B")
            {
                disableAllButtons();
                questionTimer.Stop();
                choiceBButton.BackColor = Color.DarkGreen;      // cevap doğru ise yeşil olsun.
                trueAnswerCount++;
            }
            else
            {
                disableAllButtons();
                questionTimer.Stop();
                choiceBButton.BackColor = Color.DarkRed;      // cevap yanlış ise kırmızı olsun.

                //doğru cevabı göster
                if (gameQuestions[questionCounter].getTrueAnswer() == "A") choiceAButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "C") choiceCButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "D") choiceDButton.BackColor = Color.DarkGreen;

            }
        }

        private void choiceCButton_Click(object sender, EventArgs e)
        {
            if (gameQuestions[questionCounter].getTrueAnswer() == "C")
            {

                disableAllButtons();
                questionTimer.Stop();
                choiceCButton.BackColor = Color.DarkGreen;      // cevap doğru ise yeşil olsun.
                trueAnswerCount++;
            }
            else
            {

                disableAllButtons();
                questionTimer.Stop();
                choiceCButton.BackColor = Color.DarkRed;      // cevap yanlış ise kırmızı olsun.

                //doğru cevabı göster
                if (gameQuestions[questionCounter].getTrueAnswer() == "A") choiceAButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "B") choiceBButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "D") choiceDButton.BackColor = Color.DarkGreen;

            }
        }

        private void choiceDButton_Click(object sender, EventArgs e)
        {
            if (gameQuestions[questionCounter].getTrueAnswer() == "D")
            {

                disableAllButtons();
                questionTimer.Stop();
                choiceDButton.BackColor = Color.DarkGreen;      // cevap doğru ise yeşil olsun.
                trueAnswerCount++;
            }
            else
            {

                disableAllButtons();
                questionTimer.Stop();
                choiceDButton.BackColor = Color.DarkRed;      // cevap yanlış ise kırmızı olsun.

                //doğru cevabı göster
                if (gameQuestions[questionCounter].getTrueAnswer() == "A") choiceAButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "B") choiceBButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "C") choiceCButton.BackColor = Color.DarkGreen;
            }
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if( questionTime < 1 )
            {
                //  zaman dolunca doğru cevabı göster
                questionTimer.Stop();
                if (gameQuestions[questionCounter].getTrueAnswer() == "A") choiceAButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "B") choiceBButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "C") choiceCButton.BackColor = Color.DarkGreen;
                if (gameQuestions[questionCounter].getTrueAnswer() == "D") choiceDButton.BackColor = Color.DarkGreen;
                timeOverLabel.Visible = true;
                disableAllButtons();
            }
            TimeLabel.Text = questionTime.ToString() +" Second";
            questionTime--;
           
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            loadQuestion(++questionCounter);
            audienceChart.Visible = false;
            enableAllButtons();

        }

        private void fiftyFiftyButton_Click(object sender, EventArgs e)
        {
            disableTwoWrongAnswer();
            fiftyFiftyButton.Visible = false;           //fifty fifty butons for only 1 use
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passButton_Click(object sender, EventArgs e)
        {
                 // pass buttons for only 1 use

        }

        private void askAudienceButton_Click(object sender, EventArgs e)
        {
            showAudienceChart();
            askAudienceButton.Visible = false;   //ask Audience for only 1 use 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savePointButton_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand;
            try { connnectDb.Open(); } catch { MessageBox.Show("Check your connection!","Error"); }
            try
            {
                string sqlString = "INSERT INTO Points (userNo,topicNo,point) VALUES(@userNo,@topicNo,@point)";
                sqlCommand = new SqlCommand(sqlString, connnectDb);

                sqlCommand.Parameters.AddWithValue("@userNo", onlineUserNo);
                sqlCommand.Parameters.AddWithValue("@topicNo", gameType);
                sqlCommand.Parameters.AddWithValue("@point", point);

                sqlCommand.ExecuteNonQuery();
                connnectDb.Close();
                MessageBox.Show("Your score has been added to score list successfully!", "Congratulation");
                savePointButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("You saved score for this game type before!", "Error");
            }
            finally
            {
                connnectDb.Close();
                this.Close();
                ScoreListForm scoreListForm = new ScoreListForm();
                scoreListForm.ShowDialog();
            }
        }

        private void getExtraTimeButton_Click(object sender, EventArgs e)
        {
            questionTime += 45;
            getExtraTimeButton.Visible = false;
        }
    }
    
       
}
