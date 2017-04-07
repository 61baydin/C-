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
    public partial class ScoreListForm : Form
    {
        public string onlineUserNo;
        SqlConnection connnectDb = new SqlConnection("Data Source=192.168.43.56;Initial Catalog=BilgiYarismasi_DB;User ID=bilgiYarismasi;Password=bilgiYarismasi123");

        public ScoreListForm()
        {
            InitializeComponent();
        }

        public void loadScoreList()
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            string sqlString = "Select u.name, p.point FROM Points p, Users u WHERE (u.userNo=p.userNo) AND p.topicNo = 0 ORDER BY point DESC";        //topicNo = 0  For Algorithm

            connnectDb.Open();
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlDataReader = sqlCommand.ExecuteReader();
            int scoreListCounter = 0;
            while (sqlDataReader.Read())
            {
                algorithmDataGridView.Rows.Add();
                algorithmDataGridView.Rows[scoreListCounter].Cells[0].Value = scoreListCounter+1;
                algorithmDataGridView.Rows[scoreListCounter].Cells[1].Value = sqlDataReader[0].ToString(); 
                algorithmDataGridView.Rows[scoreListCounter].Cells[2].Value = sqlDataReader[1].ToString(); 
                scoreListCounter++;
            }
            connnectDb.Close();

            sqlString = "Select u.name, p.point FROM Points p, Users u WHERE (u.userNo=p.userNo) AND p.topicNo = 1 ORDER BY point DESC";        //topicNo = 1  For OOP

            connnectDb.Open();
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlDataReader = sqlCommand.ExecuteReader();
            scoreListCounter = 0;
            while (sqlDataReader.Read())
            {
                OOPDataGridView.Rows.Add();
                OOPDataGridView.Rows[scoreListCounter].Cells[0].Value = scoreListCounter + 1;
                OOPDataGridView.Rows[scoreListCounter].Cells[1].Value = sqlDataReader[0].ToString();
                OOPDataGridView.Rows[scoreListCounter].Cells[2].Value = sqlDataReader[1].ToString();
                scoreListCounter++;
            }
            connnectDb.Close();

            sqlString = "Select u.name, p.point FROM Points p, Users u WHERE (u.userNo=p.userNo) AND p.topicNo = 2 ORDER BY point DESC";        //topicNo = 2  For softwareEngineering

            connnectDb.Open();
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlDataReader = sqlCommand.ExecuteReader();
            scoreListCounter = 0;
            while (sqlDataReader.Read())
            {
                softwareEngineeringDataGridView.Rows.Add();
                softwareEngineeringDataGridView.Rows[scoreListCounter].Cells[0].Value = scoreListCounter + 1;
                softwareEngineeringDataGridView.Rows[scoreListCounter].Cells[1].Value = sqlDataReader[0].ToString();
                softwareEngineeringDataGridView.Rows[scoreListCounter].Cells[2].Value = sqlDataReader[1].ToString();
                scoreListCounter++;
            }
            connnectDb.Close();

            sqlString = "Select u.name, p.point FROM Points p, Users u WHERE (u.userNo=p.userNo) AND p.topicNo = 3 ORDER BY point DESC";        //topicNo = 3  For Mixed

            connnectDb.Open();
            sqlCommand = new SqlCommand(sqlString, connnectDb);
            sqlDataReader = sqlCommand.ExecuteReader();
            scoreListCounter = 0;
            while (sqlDataReader.Read())
            {
                mixedDataGridView.Rows.Add();
                mixedDataGridView.Rows[scoreListCounter].Cells[0].Value = scoreListCounter + 1;
                mixedDataGridView.Rows[scoreListCounter].Cells[1].Value = sqlDataReader[0].ToString();
                mixedDataGridView.Rows[scoreListCounter].Cells[2].Value = sqlDataReader[1].ToString();
                scoreListCounter++;
            }
            connnectDb.Close();


        }

        private void ScoreListForm_Load(object sender, EventArgs e)
        {
            loadScoreList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
