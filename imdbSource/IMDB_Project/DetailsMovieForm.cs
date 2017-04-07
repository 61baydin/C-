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
    public partial class DetailsMovieForm : Form
    {

        public string gelenM_No;
        public string gelenU_No;
        int bestStarsCount = 4;
        Form1 form1 = new Form1();

        string[,] bestStarsInformation = new string[4, 3]; // 4 Best Stars Informations(Human No, Human Name ,Human Picture) 

        public DetailsMovieForm()
        {
            InitializeComponent();
        }

        private void DetailsMovieForm_Load(object sender, EventArgs e)
        {
            
            loadDetailsMovies(gelenM_No);
            loadComment();
        }

        public void addWatchList()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            string sqlString = "";
            try
            {
                con.Open();
                sqlString = "INSERT INTO WatchList (u_no,m_no,isWatched,isLiked) " +
                  "VALUES(@u_no,@m_no,@isWatched,@isLiked)";
                cmd = new SqlCommand(sqlString, con);

                cmd.Parameters.AddWithValue("@u_no", gelenU_No);
                cmd.Parameters.AddWithValue("@m_no", gelenM_No);
                cmd.Parameters.AddWithValue("@isWatched", false);
                cmd.Parameters.AddWithValue("@isLiked", false);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfull!!");
            }
            catch
            {
                MessageBox.Show("Film listenizde mevcut." , "Error!");
            }
            finally
            {

                con.Close();
            }

        }

        public void loadDetailsMovies(string gelenM_No)
        {
            Movies gelenMovie = new Movies();
            dbConnect connect = new dbConnect();
            connect.openConnect();
            string sqlString = "SELECT m.m_no,m.name,m.about,m.release_date,m.budget,m.mtime,m.trailer,m.cover,m.m_language,AVG(cm.point) AS point "+
                "FROM Movies m,CommentsOfMovie cm WHERE m.m_no='" + gelenM_No + "' AND (m.m_no=cm.m_no) GROUP BY m.m_no,m.name,m.about,m.release_date,m.budget,m.mtime,m.trailer,m.cover,m.m_language";
            connect.Command(sqlString);
            connect.dr.Read();
            gelenMovie.setValues(connect.dr[0].ToString(),
                                    connect.dr[1].ToString(),
                                        connect.dr[2].ToString(),
                                            DateTime.Parse(connect.dr[3].ToString()),
                                                connect.dr[4].ToString(),
                                                    connect.dr[5].ToString(),
                                                        connect.dr[6].ToString(),
                                                            connect.dr[7].ToString(),
                                                                connect.dr[8].ToString());
            double temp = Convert.ToDouble(connect.dr[9].ToString());
            moviePointLabel.Text = temp.ToString("N1") + " /10";
            connect.closeConnect();
            moviePictureBox.ImageLocation = gelenMovie.getCover();
            trailerPlayer.Movie = gelenMovie.getTrailer();
            movieNameLabel.Text = gelenMovie.getName();
            movieTimeLabel.Text = gelenMovie.getMtime();
            movieReleaseDateLabel.Text = gelenMovie.getRelease_date().ToString("dd MMMM yyyy");
            movieAboutLabel.Text = gelenMovie.getAbout();
            this.Text +=" ["+gelenMovie.getName()+"]" ;

            connect.openConnect();                                                                //For Movie Types
            sqlString = "SELECT t.name FROM Movies m, Types t, TypeOfMovie tm "+
                "WHERE m.m_no='" + gelenMovie.getM_no() + "' AND (m.m_no=tm.m_no) AND (tm.t_no = t.t_no)";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                gelenMovie.setMovieTypes(connect.dr[0].ToString());
            }
            connect.closeConnect();

            movieTypeLabel.Text = gelenMovie.getMovieType();

            connect.openConnect();                                                              //For Movie Directors
            sqlString = "SELECT h.name,h.l_name FROM Movies m, Human h, DirectorsOfMovie dm "+
                "WHERE m.m_no='" + gelenMovie.getM_no() + "' AND (m.m_no=dm.m_no) AND (dm.h_no = h.h_no)";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                gelenMovie.setDirectors(connect.dr[0].ToString() + " " + connect.dr[1].ToString());
            }
            connect.closeConnect();
            movieDirectorLabel.Text += gelenMovie.getDirectors();

            connect.openConnect();                                                              //For Movie Directors
            sqlString = "SELECT h.name,h.l_name FROM Movies m, Human h, AuthorsOfMovie aom " +
                "WHERE m.m_no='" + gelenMovie.getM_no() + "' AND (m.m_no=aom.m_no) AND (aom.h_no = h.h_no)";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                gelenMovie.setAuthors(connect.dr[0].ToString() + " " + connect.dr[1].ToString());
            }

            connect.closeConnect();
            movieAuthorLabel.Text += gelenMovie.getAuthors();

            connect.openConnect();                                                              //For Movie Leading Role Stars
            sqlString = "SELECT h.name,h.l_name FROM Movies m, Human h, ActorsOfMovie aom " +
                "WHERE m.m_no='" + gelenMovie.getM_no() + "' AND aom.leading_role='T' AND (m.m_no=aom.m_no) AND (aom.h_no = h.h_no)";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                gelenMovie.setLeadingRoles(connect.dr[0].ToString() + " " + connect.dr[1].ToString());
            }

            connect.closeConnect();
            movieLeadingRoleLabel.Text += gelenMovie.getLeadingRoles();



            connect.openConnect();                                                              //For Movie Actors
            sqlString = "SELECT m.m_no,h.h_no,h.name,h.l_name,h.photo,AVG(ch.point) AS moviePoint "+
                "FROM Human h, Movies m, ActorsOfMovie aom,CommentsOfHuman ch "+
                "WHERE (m.m_no='"+ gelenMovie.getM_no()+"') AND (h.h_no = aom.h_no) AND(m.m_no =aom.m_no) AND (ch.h_no=h.h_no) "+
                "GROUP BY m.m_no,h.h_no,h.name,h.l_name,h.photo ORDER BY moviePoint DESC";
            connect.Command(sqlString);
            for (int i = 0; i < bestStarsCount; i++)
            {
                connect.dr.Read();
                bestStarsInformation[i, 0] = connect.dr[1].ToString();
                bestStarsInformation[i, 1] = connect.dr[2].ToString()+" "+ connect.dr[3].ToString();
                bestStarsInformation[i, 2] = connect.dr[4].ToString();

            }
            connect.closeConnect();

            bestStarPictureBox1.ImageLocation = bestStarsInformation[0, 2];
            bestStarPictureBox2.ImageLocation = bestStarsInformation[1, 2];
            bestStarPictureBox3.ImageLocation = bestStarsInformation[2, 2];
            bestStarPictureBox4.ImageLocation = bestStarsInformation[3, 2];

            bestStarLabel1.Text = bestStarsInformation[0, 1];
            bestStarLabel2.Text = bestStarsInformation[1, 1];
            bestStarLabel3.Text = bestStarsInformation[2, 1];
            bestStarLabel4.Text = bestStarsInformation[3, 1];
           
    }

        public void loadComment()
        {
            dbConnect connect = new dbConnect();
            dbConnect forReplyConnect = new dbConnect();
            string sqlString = "";
            string replySqlString = "";
            int commentCount=0;
            connect.openConnect();
            sqlString = "SELECT Count(*) FROM CommentsOfMovie cm WHERE (cm.m_no='" + gelenM_No + "')";
            connect.Command(sqlString);
            connect.dr.Read();
            commentCount += Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();

            connect.openConnect();
            sqlString = "SELECT Count(*) FROM ReplyOfMovies rm WHERE (rm.m_no='" + gelenM_No + "')";
            connect.Command(sqlString);
            connect.dr.Read();
            commentCount += Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();
      
            Label[] comment = new Label[commentCount+1];
            int labelCounter = 0;
            int labelHeight=0;
            int commentBoxHeight = 0;
            connect.openConnect();
            comment[labelCounter] = new Label();
            comment[labelCounter].Location = new Point(1, 1);// label'imizin x ve y kordinatını yani konumunu belirledik.
            comment[labelCounter].Size = new Size(1, 1);
            comment[labelCounter].Name = "commentStartLabel";// label'imizin adını  belirledik.
            commentsPanel.Controls.Add(comment[labelCounter]);// label'imizin nereye ekleneceğini belirledik. 

            labelCounter++;
            sqlString = "SELECT cm.u_no,u.name,cm.point,cm.comment,cm.date FROM CommentsOfMovie cm , Users u WHERE (cm.u_no = u.u_no) AND "+
                "(cm.m_no='" + gelenM_No + "') ORDER BY cm.date";
            connect.Command(sqlString);
            while (connect.dr.Read())
            {
                if(connect.dr[3].ToString()=="")
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
                    else if(comment[labelCounter].Text.Length < 100)
                        labelHeight = 60;
                    else if (comment[labelCounter].Text.Length < 150)
                        labelHeight = 80;
                    else if (comment[labelCounter].Text.Length < 350)
                        labelHeight = 100;

                    comment[labelCounter].Size = new Size(550,labelHeight );// label'imizin boyutunu belirledik.
                    comment[labelCounter].Location = new Point(10 , comment[labelCounter-1].Location.Y + comment[labelCounter - 1].Height);// label'imizin x ve y kordinatını yani konumunu belirledik.
                    comment[labelCounter].Name = connect.dr[0].ToString()+"@"+connect.dr[1].ToString()+"@"+labelCounter.ToString();// label'imizin adını  belirledik.
                    commentsPanel.Controls.Add(comment[labelCounter]);// label'imizin nereye ekleneceğini belirledik. 
                    comment[labelCounter].Click += new EventHandler(comment_Click);// label'imize clilck eventi ekledik.
                    commentBoxHeight += labelHeight;
                    labelCounter++;
                    forReplyConnect.openConnect();
                    replySqlString = "SELECT ur.name,rm.comment,rm.date FROM ReplyOfMovies rm, Users ur WHERE (rm.u_no2=ur.u_no) AND "+
                        "rm.u_no='" + connect.dr[0].ToString() + "' " +
                        "AND rm.m_no='" + gelenM_No + "'" +
                        "ORDER BY rm.date";
                    
                    forReplyConnect.Command(replySqlString);
                    while(forReplyConnect.dr.Read())
                    {
                        comment[labelCounter] = new Label(); // bu kısımda deneme kod adlı label dizisinin ilk elemanının form ekranına eklenicek yeni bir label olduğunu belirttik.
                        comment[labelCounter].Font = new Font("Microsoft Sans Serif", 9,FontStyle.Bold);// bu kısımda ise label'imize bir font belirledik.
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
            }//---
            connect.closeConnect();
            pointComboBox.SelectedIndex = 0;
            if(gelenU_No == null)
            {

                newCommentGroupBox.Enabled = false;
                pointComboBox.Text = "";
            }
            commentsGroupBox.Size = new Size(697, commentBoxHeight + 30);
            
        }

        private void comment_Click(object sender, EventArgs e)
        {
            Label ogren = sender as Label;
            replyToLabel.Text = ogren.Name;
            removeReplyButton.Visible = true;
            pointComboBox.Text = "";
            pointComboBox.Enabled = false;
        }

        private void bestStarPictureBox1_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = bestStarsInformation[0, 0];
            detailHuman.gelenU_No = gelenU_No;
            this.Close();
            detailHuman.Show();

        }

        private void bestStarPictureBox2_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = bestStarsInformation[1, 0];
            detailHuman.gelenU_No = gelenU_No;
            this.Close();
            detailHuman.Show();
        }

        private void bestStarPictureBox3_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = bestStarsInformation[2, 0];
            detailHuman.gelenU_No = gelenU_No;
            this.Close();
            detailHuman.Show();
        }

        private void bestStarPictureBox4_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = bestStarsInformation[3, 0];
            detailHuman.gelenU_No = gelenU_No;
            this.Close();
            detailHuman.Show();
        }

        private void sendCommentButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            if ( gelenU_No != null && replyToLabel.Text=="#")
            {
                try
                {
                    con.Open();
                    string sqlString;
                    sqlString = "INSERT INTO CommentsOfMovie (u_no,m_no,point,comment,date) " +
                      "VALUES(@u_no,@m_no,@point,@comment,@date)";
                     cmd = new SqlCommand(sqlString, con);
           
                    cmd.Parameters.AddWithValue("@u_no", gelenU_No);
                    cmd.Parameters.AddWithValue("@m_no", gelenM_No);
                    cmd.Parameters.AddWithValue("@point",pointComboBox.Text);
                    cmd.Parameters.AddWithValue("@comment",commentTextBox.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToLocalTime());          
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Yorum Yapıldı");
                    commentTextBox.Clear();
                }
                catch (SqlException hata)
                {
                    MessageBox.Show(hata.Message.ToString()+"Yorum Yapamazsınız");
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
                    sqlString = "INSERT INTO ReplyOfMovies (u_no,m_no,u_no2,comment,date) " +
                      "VALUES(@u_no,@m_no,@u_no2,@comment,@date)";
                    cmd = new SqlCommand(sqlString, con);

                    cmd.Parameters.AddWithValue("@u_no", replyUserNo);
                    cmd.Parameters.AddWithValue("@m_no", gelenM_No);
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

        private void addWatchListPictureBox_Click(object sender, EventArgs e)
        {
            if(gelenU_No != null)
            {
                addWatchList();
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapınız.");
            }
               
        }
    }
}
