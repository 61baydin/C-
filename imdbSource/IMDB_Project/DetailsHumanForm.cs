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
    public partial class DetailsHumanForm : Form
    {
        int knownForCount;
        public string gelenH_No;
        public string gelenU_No;
        string[,] knownForInformation = new string[4,3]; // 4 Known For Informations(Movie no, Movie Name ,Movie Cover) 
        public DetailsHumanForm()
        {
            InitializeComponent();
        }

        public void loadDetailsHuman(string gelenH_No)
        {
            Human gelenHuman = new Human();
            dbConnect connect = new dbConnect();
            connect.openConnect();
            string sqlString = "SELECT h.*,AVG(ch.point) FROM Human h, CommentsOfHuman ch WHERE h.h_no ='" + gelenH_No + "' AND (h.h_no = ch.h_no)  GROUP BY h.h_no,h.name,h.l_name,h.b_date,h.city,h.country,h.biography,h.height,h.photo,h.sex,h.actorFlag,h.authorFlag,h.directorFlag";
            connect.Command(sqlString);
            connect.dr.Read();
            gelenHuman.setValues(connect.dr[0].ToString(),
                                   connect.dr[1].ToString(),
                                       connect.dr[2].ToString(),
                                           DateTime.Parse(connect.dr[3].ToString()),
                                               connect.dr[4].ToString(),
                                                   connect.dr[5].ToString(),
                                                       connect.dr[6].ToString(),
                                                           connect.dr[7].ToString(),
                                                               connect.dr[8].ToString(),
                                                                   Convert.ToChar(connect.dr[9].ToString()),
                                                                         Convert.ToBoolean(connect.dr[10].ToString()),
                                                                             Convert.ToBoolean(connect.dr[11].ToString()),
                                                                                Convert.ToBoolean(connect.dr[12].ToString()));


            humanPointLabel.Text = connect.dr[13].ToString() + " /10";
            connect.closeConnect();
            humanPictureBox.ImageLocation = gelenHuman.getPhoto();
            humanNameLabel.Text = gelenHuman.getName()+" "+ gelenHuman.getL_name();
            this.Text += " [" + gelenHuman.getName() + " " + gelenHuman.getL_name() +"]";
            humanBODLabel.Text = gelenHuman.getB_date().ToString("dd MMMM yyyy");
            humanCityLabel.Text = gelenHuman.getCity()+", "+gelenHuman.getCountry();
            humanBiographyLabel.Text = gelenHuman.getBiography();
            humanHeightLabel.Text += gelenHuman.getHeight() + " cm";
            humanSexLabel.Text = gelenHuman.getSex();
            humanJobLabel.Text = gelenHuman.getJobs();

            
            connect.openConnect();
            sqlString = "SELECT COUNT(*) FROM Human h, Movies m, ActorsOfMovie aom WHERE (h.h_no='" + gelenH_No + "') AND (h.h_no = aom.h_no) AND(m.m_no = aom.m_no) UNION " +
                            "SELECT COUNT(*) FROM Human h, Movies m, AuthorsOfMovie auom WHERE(h.h_no = '" + gelenH_No + "') AND(h.h_no = auom.h_no) AND(m.m_no = auom.m_no) UNION " +
                                "SELECT COUNT(*) FROM Human h, Movies m, DirectorsOfMovie dom WHERE(h.h_no = '" + gelenH_No + "') AND(h.h_no = Dom.h_no) AND(m.m_no = dom.m_no)";
            connect.Command(sqlString);
            while(connect.dr.Read())
            {
                knownForCount += Convert.ToInt32(connect.dr[0].ToString());
            }
            connect.closeConnect();
            
            if (knownForCount > 4)
                knownForCount = 4;
            connect.openConnect();
            sqlString = "SELECT h.h_no,m.m_no,m.name,m.cover FROM Human h, Movies m, ActorsOfMovie aom WHERE (h.h_no='" + gelenH_No + "') AND (h.h_no = aom.h_no) AND (m.m_no = aom.m_no) GROUP BY h.h_no,m.m_no,m.name,m.cover UNION " +
                            "SELECT h.h_no,m.m_no,m.name,m.cover FROM Human h, Movies m, AuthorsOfMovie auom WHERE(h.h_no = '" + gelenH_No + "') AND(h.h_no = auom.h_no) AND(m.m_no = auom.m_no) GROUP BY h.h_no,m.m_no,m.name,m.cover UNION " +
                                "SELECT h.h_no,m.m_no,m.name,m.cover FROM Human h, Movies m, DirectorsOfMovie dom WHERE(h.h_no = '" + gelenH_No + "') AND(h.h_no = dom.h_no) AND(m.m_no = dom.m_no) GROUP BY h.h_no,m.m_no,m.name,m.cover";
            connect.Command(sqlString);
            
            for (int i = 0; i < knownForCount; i++)
            {
                connect.dr.Read();
              
                    knownForInformation[i, 0] = connect.dr[2].ToString();
                    knownForInformation[i, 1] = connect.dr[3].ToString();
                    knownForInformation[i, 2] = connect.dr[1].ToString();
                



            }
            connect.closeConnect();
            knownForPictureBox1.ImageLocation = knownForInformation[0, 1];
            knownForPictureBox2.ImageLocation = knownForInformation[1, 1];
            knownForPictureBox3.ImageLocation = knownForInformation[2, 1];
            knownForPictureBox4.ImageLocation = knownForInformation[3, 1];
            knownForLabel1.Text = knownForInformation[0, 0];
            knownForLabel2.Text = knownForInformation[1, 0];
            knownForLabel3.Text = knownForInformation[2, 0];
            knownForLabel4.Text = knownForInformation[3, 0];

        }
        public void loadComment()
        {
            dbConnect connect = new dbConnect();
            dbConnect forReplyConnect = new dbConnect();
            string sqlString = "";
            string replySqlString = "";
            int commentCount = 0;
            connect.openConnect();
            sqlString = "SELECT Count(*) FROM CommentsOfHuman ch WHERE (ch.h_no='" + gelenH_No + "')";
            connect.Command(sqlString);
            connect.dr.Read();
            commentCount += Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();

            connect.openConnect();
            sqlString = "SELECT Count(*) FROM ReplyOfHuman rh WHERE (rh.h_no='" + gelenH_No + "')";
            connect.Command(sqlString);
            connect.dr.Read();
            commentCount += Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();
                        
            Label[] comment = new Label[commentCount + 1];
            int labelCounter = 0;
            int labelHeight = 0;
            int commentBoxHeight=0;
            connect.openConnect();
            comment[labelCounter] = new Label();
            comment[labelCounter].Location = new Point(1, 1);// label'imizin x ve y kordinatını yani konumunu belirledik.
            comment[labelCounter].Size = new Size(1, 1);
            comment[labelCounter].Name = "commentStartLabel";// label'imizin adını  belirledik.
            commentsPanel.Controls.Add(comment[labelCounter]);// label'imizin nereye ekleneceğini belirledik. 
        
            labelCounter++;
            sqlString = "SELECT ch.u_no,u.name,ch.point,ch.comment,ch.date FROM CommentsOfHuman ch , Users u WHERE (ch.u_no = u.u_no) AND " +
                "(ch.h_no='" + gelenH_No + "') ORDER BY ch.date";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                if (connect.dr[3].ToString() == "")
                {

                }
                else
                {
                    comment[labelCounter] = new Label(); // bu kısımda deneme kod adlı label dizisinin ilk elemanının form ekranına eklenicek yeni bir label olduğunu belirttik.
                    comment[labelCounter].Font = new Font("Microsoft Sans Serif", 9);// bu kısımda ise label'imize bir font belirledik.
                    comment[labelCounter].ForeColor = Color.Black;// label'imizin yazı rengini belirledik.
                    comment[labelCounter].Text = connect.dr[1].ToString() + ":\n" + connect.dr[3].ToString();
                    if (comment[labelCounter].Text.Length < 50)
                    {
                        labelHeight = 40;
                    }
                    else if (comment[labelCounter].Text.Length < 100)
                        labelHeight = 60;
                    else if (comment[labelCounter].Text.Length < 150)
                        labelHeight = 80;
                    else if (comment[labelCounter].Text.Length < 350)
                        labelHeight = 100;

                    comment[labelCounter].Size = new Size(550, labelHeight);// label'imizin boyutunu belirledik.
                    comment[labelCounter].Location = new Point(10, comment[labelCounter - 1].Location.Y + comment[labelCounter - 1].Height);// label'imizin x ve y kordinatını yani konumunu belirledik.
                    comment[labelCounter].Name = connect.dr[0].ToString() + "@" + connect.dr[1].ToString() + "@" + labelCounter.ToString();// label'imizin adını  belirledik.
                    commentsPanel.Controls.Add(comment[labelCounter]);// label'imizin nereye ekleneceğini belirledik. 
                    comment[labelCounter].Click += new EventHandler(comment_Click);// label'imize clilck eventi ekledik.
                    commentBoxHeight += labelHeight;
                    labelCounter++;
                    forReplyConnect.openConnect();
                    replySqlString = "SELECT ur.name,rh.comment,rh.date FROM ReplyOfHuman rh, Users ur WHERE (rh.u_no2=ur.u_no) AND " +
                        "rh.u_no='" + connect.dr[0].ToString() + "' " +
                        "AND rh.h_no='" + gelenH_No + "'" +
                        "ORDER BY rh.date";

                    forReplyConnect.Command(replySqlString);
                    while (forReplyConnect.dr.Read())
                    {
                        comment[labelCounter] = new Label(); // bu kısımda deneme kod adlı label dizisinin ilk elemanının form ekranına eklenicek yeni bir label olduğunu belirttik.
                        comment[labelCounter].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);// bu kısımda ise label'imize bir font belirledik.
                        comment[labelCounter].ForeColor = Color.DimGray;// label'imizin yazı rengini belirledik.
                        comment[labelCounter].Text = forReplyConnect.dr[0].ToString() + ": \n" + forReplyConnect.dr[1].ToString();// label'imizin yazı rengini belirledik.
                        if (comment[labelCounter].Text.Length < 50)
                        {
                            labelHeight = 40;
                        }
                        else if (comment[labelCounter].Text.Length < 100)
                            labelHeight = 60;
                        else if (comment[labelCounter].Text.Length < 150)
                            labelHeight = 80;
                        else if (comment[labelCounter].Text.Length < 350)
                            labelHeight = 100;

                        comment[labelCounter].Size = new Size(550, labelHeight);
                        comment[labelCounter].Location = new Point(50, comment[labelCounter - 1].Location.Y + comment[labelCounter - 1].Height);// label'imizin x ve y kordinatını yani konumunu belirledik.
                        comment[labelCounter].Name = labelCounter.ToString();// label'imizin adını  belirledik. Ben burada direkt sayı olarak verdim isimlerini fakat form ekranında aynı isimde eleman olur ise sorun çıkabilir.
                        commentsPanel.Controls.Add(comment[labelCounter]);// label'imizin nereye ekleneceğini belirledik. Direkt form ekranına ekleyecek iseniz This.Controls.Add() komutunu kullanabilirsiniz.
                                                                          //comment[labelCounter].Click += new EventHandler(comment_Click);// label'imize clilck eventi ekledik.
                        commentBoxHeight += labelHeight;
                        labelCounter++;
                    }
                    forReplyConnect.closeConnect();

                }
            }
            connect.closeConnect();
                pointComboBox.SelectedIndex = 0;
                if (gelenU_No == null)
                {

                    newCommentGroupBox.Enabled = false;

                    pointComboBox.Text = "";
                }
            commentsGroupBox.Size = new Size(697, commentBoxHeight+30);


        }
        private void comment_Click(object sender, EventArgs e)
        {
            Label ogren = sender as Label;
            replyToLabel.Text = ogren.Name;
            removeReplyButton.Visible = true;
            pointComboBox.Text = "";
            pointComboBox.Enabled = false;
        }

        private void DetailsHumanForm_Load(object sender, EventArgs e)
        {
            loadComment();
            loadDetailsHuman(gelenH_No);
            humanPictureBox.Select();


        }

        private void knownForPictureBox1_Click(object sender, EventArgs e)
        {
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = knownForInformation[0,2];
            detailMovie.gelenU_No = gelenU_No;
            this.Close();
            detailMovie.Show();
        }

        private void knownForPictureBox2_Click(object sender, EventArgs e)
        {
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = knownForInformation[1, 2];
            detailMovie.gelenU_No = gelenU_No;
            this.Close();
            detailMovie.Show();

        }

        private void knownForPictureBox3_Click(object sender, EventArgs e)
        {
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = knownForInformation[2, 2];
            detailMovie.gelenU_No = gelenU_No;
            this.Close();
            detailMovie.Show();
        }

        private void knownForPictureBox4_Click(object sender, EventArgs e)
        {
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = knownForInformation[3, 2];
            detailMovie.gelenU_No = gelenU_No;
            this.Close();
            detailMovie.Show();
        }

        private void sendCommentButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            if ( gelenU_No != null && replyToLabel.Text == "#")
            {
                try
                {
                    con.Open();
                    string sqlString;
                    sqlString = "INSERT INTO CommentsOfHuman (u_no,h_no,point,comment,date) " +
                      "VALUES(@u_no,@m_no,@point,@comment,@date)";
                    cmd = new SqlCommand(sqlString, con);

                    cmd.Parameters.AddWithValue("@u_no", gelenU_No);
                    cmd.Parameters.AddWithValue("@m_no", gelenH_No);
                    cmd.Parameters.AddWithValue("@point", pointComboBox.Text);
                    cmd.Parameters.AddWithValue("@comment", commentTextBox.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToLocalTime());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Yorum Yapıldı");
                    commentTextBox.Clear();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message.ToString() + "Yorum Yapamazsınız");
                }
                finally
                {

                    con.Close();
                }
            }
            else if (commentTextBox.TextLength > 0 && gelenU_No != null && replyToLabel.Text != "#")
            {
                string replyUserNo = replyToLabel.Text.Substring(0, replyToLabel.Text.IndexOf("@"));
                try
                {
                    con.Open();
                    string sqlString;
                    sqlString = "INSERT INTO ReplyOfHuman (u_no,h_no,u_no2,comment,date) " +
                      "VALUES(@u_no,@m_no,@u_no2,@comment,@date)";
                    cmd = new SqlCommand(sqlString, con);

                    cmd.Parameters.AddWithValue("@u_no", replyUserNo);
                    cmd.Parameters.AddWithValue("@m_no", gelenH_No);
                    cmd.Parameters.AddWithValue("@u_no2", gelenU_No);
                    cmd.Parameters.AddWithValue("@comment", commentTextBox.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToLocalTime());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Yorum Yapıldı");
                    commentTextBox.Clear();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message.ToString() + "Yorum Yapamazsınız");
                }
                finally
                {

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Giriş yapmadan yorum yazamazsınız.");
            }
        }

        private void removeReplyButton_Click(object sender, EventArgs e)
        {

            replyToLabel.Text = "#";
            removeReplyButton.Visible = false;
        }
    }
}
