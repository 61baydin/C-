using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMDB_Project
{
   
    public partial class Form1 : Form
    {

        public string userNo;
        Movies[] comingSoonMovie = new Movies[10];
        Human[] topTenCelebHuman = new Human[10];
        User user = new User();
        int topCelebCount =10;
        int comingSoonCount = 10;
        int comingSoonCounter=0; // Coming Soon Count 
        const int RECOMMENDEDCOUNT = 5;
        string today = DateTime.Now.ToString("yyyy-MM-dd");
        string forBornToday = DateTime.Now.ToString("dd-MM");
        public Form1()
        {
            InitializeComponent();
        }
    
       
       
        public void loadComingSoon()
        {
            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "SELECT * FROM Movies WHERE release_date > '"+ today +"'"; 
            baglan.Command(sqlString);
            for (int i = 0; i < comingSoonCount; i++)  //  Coming soon kısmında gösterilecek 10 filmi nesnelere çeker.
            {             
                baglan.dr.Read();
                comingSoonMovie[i] = new Movies();
                comingSoonMovie[i].setValues(baglan.dr[0].ToString(),
                                   baglan.dr[1].ToString(),
                                       baglan.dr[2].ToString(),
                                           DateTime.Parse(baglan.dr[3].ToString()),
                                               baglan.dr[4].ToString(),
                                                   baglan.dr[5].ToString(),
                                                       baglan.dr[6].ToString(),
                                                           baglan.dr[7].ToString(),
                                                               baglan.dr[8].ToString());

            }
            baglan.closeConnect();
            for (int i=0;i< comingSoonCount; i++)
            {
                baglan.openConnect();
                sqlString = "SELECT t.name FROM Movies m, Types t, TypeOfMovie tm WHERE m.m_no='"+ comingSoonMovie[i].getM_no().ToString() + "' AND (m.m_no=tm.m_no) AND (tm.t_no = t.t_no)";
                baglan.Command(sqlString);
                while(baglan.dr.Read())
                {
                    comingSoonMovie[i].setMovieTypes(baglan.dr[0].ToString());
                }

                baglan.closeConnect();
            }
            
            coverPictureBox.ImageLocation = comingSoonMovie[0].getCover().ToString();
            trailerPlayer.Movie = comingSoonMovie[0].getTrailer().ToString();
            movieNameLabel.Text = comingSoonMovie[0].getName().ToString();
            movieAboutLabel.Text = comingSoonMovie[0].getAbout().ToString();
            releaseDateLabel.Text = "Release Date: " + comingSoonMovie[0].getRelease_date().ToString("dd MMMM yyyy");
            typeOfMovieLabel.Text = comingSoonMovie[0].getMovieType().ToString();

        }
        public void loadTopTenCeleb()
        {
            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "SELECT h.h_no,h.name,h.l_name,h.photo,AVG(ch.point) as AvgPoint FROM Human h, CommentsOfHuman ch " +
                "WHERE (h.h_no=ch.h_no) AND (h.actorFlag='TRUE') GROUP BY h.h_no,h.name,h.l_name, h.photo ORDER BY AvgPoint DESC";
            baglan.Command(sqlString);

            for (int i = 0; i < topCelebCount; i++)  //  Coming soon kısmında gösterilecek 10 filmi nesnelere çeker.
            {
                baglan.dr.Read();
                topTenCelebHuman[i] = new Human();
                topTenCelebHuman[i].setTopCelebInfo(baglan.dr[0].ToString(),
                                   baglan.dr[1].ToString(),
                                   baglan.dr[2].ToString(),
                                   baglan.dr[3].ToString());

            }
            baglan.closeConnect();
            topTenCelebPictureBox1.ImageLocation = topTenCelebHuman[0].getPhoto();
            topTenCelebPictureBox2.ImageLocation = topTenCelebHuman[1].getPhoto();
            topTenCelebPictureBox3.ImageLocation = topTenCelebHuman[2].getPhoto();
            topTenCelebPictureBox4.ImageLocation = topTenCelebHuman[3].getPhoto();
            topTenCelebPictureBox5.ImageLocation = topTenCelebHuman[4].getPhoto();
            topTenCelebPictureBox6.ImageLocation = topTenCelebHuman[5].getPhoto();
            topTenCelebPictureBox7.ImageLocation = topTenCelebHuman[6].getPhoto();
            topTenCelebPictureBox8.ImageLocation = topTenCelebHuman[7].getPhoto();
            topTenCelebPictureBox9.ImageLocation = topTenCelebHuman[8].getPhoto();
            topTenCelebPictureBox10.ImageLocation = topTenCelebHuman[9].getPhoto();

            topTenCelebLabel1.Text = topTenCelebHuman[0].getName() + " " + topTenCelebHuman[0].getL_name();
            topTenCelebLabel2.Text = topTenCelebHuman[1].getName() + " " + topTenCelebHuman[1].getL_name();
            topTenCelebLabel3.Text = topTenCelebHuman[2].getName() + " " + topTenCelebHuman[2].getL_name();
            topTenCelebLabel4.Text = topTenCelebHuman[3].getName() + " " + topTenCelebHuman[3].getL_name();
            topTenCelebLabel5.Text = topTenCelebHuman[4].getName() + " " + topTenCelebHuman[4].getL_name();
            topTenCelebLabel6.Text = topTenCelebHuman[5].getName() + " " + topTenCelebHuman[5].getL_name();
            topTenCelebLabel7.Text = topTenCelebHuman[6].getName() + " " + topTenCelebHuman[6].getL_name();
            topTenCelebLabel8.Text = topTenCelebHuman[7].getName() + " " + topTenCelebHuman[7].getL_name();
            topTenCelebLabel9.Text = topTenCelebHuman[8].getName() + " " + topTenCelebHuman[8].getL_name();
            topTenCelebLabel10.Text = topTenCelebHuman[9].getName() + " " + topTenCelebHuman[9].getL_name();
        }

            AutoCompleteStringCollection movieList = new AutoCompleteStringCollection();
            AutoCompleteStringCollection humanList = new AutoCompleteStringCollection();
        public void loadSearchText()
        {
           
            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "SELECT name,l_name FROM Human";
            baglan.Command(sqlString);
            while (baglan.dr.Read())
            {
                humanList.Add(baglan.dr[0].ToString() + " " + baglan.dr[1].ToString());
            }
            baglan.closeConnect();
            baglan.openConnect();
            sqlString = "SELECT name, m_no FROM Movies";
            baglan.Command(sqlString);
            while (baglan.dr.Read())
            {
                movieList.Add(baglan.dr[0].ToString());
               

            }
            baglan.closeConnect();
            
        }

        public void loadRecommendedMovies()
        {
            recomendedMoviesPanel.Controls.Clear();
            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "";
            if (user.getU_No()!=null)
            {
                sqlString = "SELECT TOP 5 m.* FROM Movies m, TypeOfMovie tm WHERE (tm.m_no=m.m_no) AND tm.t_no=(" +
                                "SELECT TOP 1 t_no From WatchList wl, TypeOfMovie tm WHERE wl.m_no = tm.m_no AND wl.u_no='" + user.getU_No() + "'" +
                                "ORDER BY NEWID())";

            }
            else
            {
                sqlString = "SELECT TOP 5 m.* FROM Movies m ORDER BY NEWID()";

            }
            Label[] name = new Label[RECOMMENDEDCOUNT + 1];
            PictureBox[] recommendedMovieCover = new PictureBox[RECOMMENDEDCOUNT + 1];

            int recommendedCounter = 0;
            name[recommendedCounter] = new Label();
            name[recommendedCounter].Location = new Point(-150, 250);
            name[recommendedCounter].Size = new Size(0, 0);
            name[recommendedCounter].AutoSize = false;

            name[recommendedCounter].Name = "RecommendedMovieNameStartPosition";
            recomendedMoviesPanel.Controls.Add(name[recommendedCounter]);

            recommendedMovieCover[recommendedCounter] = new PictureBox();
            recommendedMovieCover[recommendedCounter].Location = new Point(-150, 3);
            recommendedMovieCover[recommendedCounter].Size = new Size(0, 0);
            recommendedMovieCover[recommendedCounter].Name = "RecommendedMovieCoverStartPosition";
            recomendedMoviesPanel.Controls.Add(recommendedMovieCover[recommendedCounter]);

            baglan.openConnect();
            baglan.Command(sqlString);

            while (baglan.dr.Read())
            {
                recommendedCounter++;


                recommendedMovieCover[recommendedCounter] = new PictureBox();
                recommendedMovieCover[recommendedCounter].ForeColor = Color.Black;
                recommendedMovieCover[recommendedCounter].ImageLocation = baglan.dr[7].ToString();
                recommendedMovieCover[recommendedCounter].SizeMode = PictureBoxSizeMode.StretchImage;
                recommendedMovieCover[recommendedCounter].Location = new Point(recommendedMovieCover[recommendedCounter - 1].Location.X + 156, 3);
                recommendedMovieCover[recommendedCounter].Size = new Size(150, 245);
                recommendedMovieCover[recommendedCounter].Click += new EventHandler(movieCover_Click);
                recommendedMovieCover[recommendedCounter].MaximumSize = new Size(150, 245);
                recommendedMovieCover[recommendedCounter].Name = baglan.dr[0].ToString() + "@RecommendedMovieCoverPictureBox";
                recomendedMoviesPanel.Controls.Add(recommendedMovieCover[recommendedCounter]);


                name[recommendedCounter] = new Label();
                name[recommendedCounter].Font = new Font("Times New Roman", 11,FontStyle.Bold);
                name[recommendedCounter].ForeColor = Color.Black;
                name[recommendedCounter].Name = baglan.dr[0].ToString() + "@NameLabel";
                name[recommendedCounter].Click += new EventHandler(nameLabel_Click);
                name[recommendedCounter].Text = baglan.dr[1].ToString();
                name[recommendedCounter].Location = new Point(name[recommendedCounter - 1].Location.X + 156, 250);
                name[recommendedCounter].AutoSize = false;
                name[recommendedCounter].Size = new Size(150, 35);
                name[recommendedCounter].MaximumSize = new Size(150, 35);
                recomendedMoviesPanel.Controls.Add(name[recommendedCounter]);

            }
            baglan.closeConnect();



        }
        private void nameLabel_Click(object sender, EventArgs e)
        {
            string m_no = "";
            Label ogren = sender as Label;
            m_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = m_no;
            detailMovie.gelenU_No = user.getU_No();
            detailMovie.ShowDialog();

        }

        private void movieCover_Click(object sender, EventArgs e)
        {
            string m_no = "";
            PictureBox ogren = sender as PictureBox;
            m_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = m_no;
            detailMovie.gelenU_No = user.getU_No();
            detailMovie.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadComingSoon();
            topTenCelebGroupBox.Text += DateTime.Now.Year.ToString();
            loadTopTenCeleb();
            loadSearchText();
            searchTextBox.Select();
            searchTypeComboBox.SelectedIndex = 0;
            loadRecommendedMovies();

        }

        private void shiftLeftButton_Click(object sender, EventArgs e)
        {
            if (comingSoonCounter == 0)
            {
                comingSoonCounter = 9;
                coverPictureBox.ImageLocation = comingSoonMovie[comingSoonCounter].getCover().ToString();
                trailerPlayer.Movie = comingSoonMovie[comingSoonCounter].getTrailer().ToString();
                movieNameLabel.Text = comingSoonMovie[comingSoonCounter].getName().ToString();
                movieAboutLabel.Text = comingSoonMovie[comingSoonCounter].getAbout().ToString();
                releaseDateLabel.Text = comingSoonMovie[comingSoonCounter].getRelease_date().ToString("dd MMMM yyyy");
                typeOfMovieLabel.Text = comingSoonMovie[comingSoonCounter].getMovieType().ToString();
            }
            else
            {
                comingSoonCounter--;
                coverPictureBox.ImageLocation = comingSoonMovie[comingSoonCounter].getCover().ToString();
                trailerPlayer.Movie = comingSoonMovie[comingSoonCounter].getTrailer().ToString();
                movieNameLabel.Text = comingSoonMovie[comingSoonCounter].getName().ToString();
                movieAboutLabel.Text = comingSoonMovie[comingSoonCounter].getAbout().ToString();
                releaseDateLabel.Text = comingSoonMovie[comingSoonCounter].getRelease_date().ToString("dd MMMM yyyy");
                typeOfMovieLabel.Text = comingSoonMovie[comingSoonCounter].getMovieType().ToString();


            }
        }

        private void shiftRightButton_Click(object sender, EventArgs e)
        {
            if ( comingSoonCounter==9)
            {
                comingSoonCounter = 0;
                coverPictureBox.ImageLocation = comingSoonMovie[comingSoonCounter].getCover().ToString();
                trailerPlayer.Movie = comingSoonMovie[comingSoonCounter].getTrailer().ToString();
                movieNameLabel.Text = comingSoonMovie[comingSoonCounter].getName().ToString();
                movieAboutLabel.Text = comingSoonMovie[comingSoonCounter].getAbout().ToString();
                releaseDateLabel.Text = comingSoonMovie[comingSoonCounter].getRelease_date().ToString("dd MMMM yyyy");
                typeOfMovieLabel.Text = comingSoonMovie[comingSoonCounter].getMovieType().ToString();
            }
            else
            {
                comingSoonCounter++;
                coverPictureBox.ImageLocation = comingSoonMovie[comingSoonCounter].getCover().ToString();
                trailerPlayer.Movie = comingSoonMovie[comingSoonCounter].getTrailer().ToString();
                movieNameLabel.Text = comingSoonMovie[comingSoonCounter].getName().ToString();
                movieAboutLabel.Text = comingSoonMovie[comingSoonCounter].getAbout().ToString();
                releaseDateLabel.Text = comingSoonMovie[comingSoonCounter].getRelease_date().ToString("dd MMMM yyyy");
                typeOfMovieLabel.Text = comingSoonMovie[comingSoonCounter].getMovieType().ToString();

            }

        }

        private void signInbutton_Click(object sender, EventArgs e)
        {
            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "SELECT * FROM Users WHERE email='" + emailTextBox.Text.ToString() + "' AND pass='" + passwordTextBox.Text.ToString()+"'" ;
            baglan.Command(sqlString);
            baglan.dr.Read();
            if(baglan.dr.HasRows)
            {
                user.setValue(baglan.dr[0].ToString(),
                                baglan.dr[1].ToString(),
                                    baglan.dr[2].ToString(),
                                        baglan.dr[3].ToString(),
                                            Convert.ToBoolean(baglan.dr[4].ToString()));
                loginPanel.Visible = false;
                loginInPanel.Visible = true;
                userNameLabel.Text = user.getName();
                userNo = user.getU_No();
                signUpToolStripMenuItem.Enabled = false;
                signOutToolStripMenuItem.Visible = true;
                myWatchlistToolStripMenuItem.Visible = true;
                myWatchedListToolStripMenuItem.Visible = true;
                loadRecommendedMovies();
                if(user.getIsAdmin())
                {
                    adminPanelToolStripMenuItem.Visible = true;
                    adminPanelButton.Visible = true;
                    
                   
                }
                else
                {
                    adminPanelButton.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Hatalı Giriş.","Error");
            }
            baglan.closeConnect();


        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = null;
            passwordTextBox.Text = null;

            loginPanel.Visible = true;
            loginInPanel.Visible = false;
            userNameLabel.Text ="User Name";
            user.setValue(null, null, null, null, false);
            signUpToolStripMenuItem.Enabled = true;
            signOutToolStripMenuItem.Visible = false;
            adminPanelToolStripMenuItem.Visible = false;
            myWatchlistToolStripMenuItem.Visible = false;
            myWatchedListToolStripMenuItem.Visible = false;
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminpnl = new AdminPanelForm();
            adminpnl.ShowDialog();
        }

        private void e(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                this.signInbutton_Click(sender,e);
             
            }
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            comingSoonCounter = 0;
            coverPictureBox.ImageLocation = comingSoonMovie[comingSoonCounter].getCover().ToString();
            trailerPlayer.Movie = comingSoonMovie[comingSoonCounter].getTrailer().ToString();
            movieNameLabel.Text = comingSoonMovie[comingSoonCounter].getName().ToString();
            movieAboutLabel.Text = comingSoonMovie[comingSoonCounter].getAbout().ToString();
            releaseDateLabel.Text = comingSoonMovie[comingSoonCounter].getRelease_date().ToString("dd MMMM yyyy");
            typeOfMovieLabel.Text = comingSoonMovie[comingSoonCounter].getMovieType().ToString();
        }

        private void topTenCelebLabel1_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[0].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel2_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[1].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel3_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[2].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel4_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[3].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel5_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[4].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel6_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[5].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel7_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[6].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel8_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[7].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel9_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[8].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void topTenCelebLabel10_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[9].getH_no().ToString();
            detailHuman.ShowDialog();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string sqlString = "";
            con.Open();
            if (searchTypeComboBox.SelectedIndex==1)
            {
                sqlString = "SELECT m_no,name FROM Movies WHERE name=@name";
                cmd = new SqlCommand(sqlString, con);

                cmd.Parameters.AddWithValue("@name", searchTextBox.Text);
                dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    DetailsMovieForm detailMovie = new DetailsMovieForm();
                    detailMovie.gelenM_No = dr[0].ToString();
                    detailMovie.gelenU_No = user.getU_No();
                    detailMovie.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aradığınız film bulunamadı.");
                }
                con.Close();
            }
            else
            {
                sqlString = "SELECT h_no,name,l_name FROM Human WHERE name=@name AND l_name=@l_name";
                cmd = new SqlCommand(sqlString, con);
                string name,lname;
                if(searchTextBox.TextLength<3)
                {
                    MessageBox.Show("Lütfen aranacak kişinin isim ve soyadını giriniz.");
                }
                else
                {
                    int temp = searchTextBox.Text.IndexOf(" ");
                    name = searchTextBox.Text.Substring(0, temp);
                    temp++;
                    lname = searchTextBox.Text.Substring(temp, searchTextBox.Text.Length - temp);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@l_name", lname);
                    dr = cmd.ExecuteReader();

                    dr.Read();
                    if (dr.HasRows)
                    {
                        DetailsHumanForm detailHuman = new DetailsHumanForm();
                        detailHuman.gelenH_No = dr[0].ToString();
                        detailHuman.gelenU_No = user.getU_No();
                        detailHuman.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Aradığınız kişi bulunamadı.");
                    }
                    con.Close();
                }
                
            }
            

           
        }

        private void topTenCelebPictureBox1_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[0].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();


        }

        private void topTenCelebPictureBox2_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[1].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox3_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[2].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox4_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[3].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox5_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[4].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox6_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[5].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox7_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[6].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox8_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[7].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox9_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[8].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void topTenCelebPictureBox10_Click(object sender, EventArgs e)
        {
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = topTenCelebHuman[9].getH_no().ToString();
            detailHuman.gelenU_No = user.getU_No();
            detailHuman.ShowDialog();
        }

        private void coverPictureBox_Click(object sender, EventArgs e)
        {
            DetailsMovieForm detailMovie = new DetailsMovieForm();
            detailMovie.gelenM_No = comingSoonMovie[comingSoonCounter].getM_no();
            detailMovie.gelenU_No = user.getU_No();
            detailMovie.ShowDialog();

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        private void searchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ( searchTypeComboBox.SelectedIndex ==0)
                searchTextBox.AutoCompleteCustomSource = humanList;
            else
                searchTextBox.AutoCompleteCustomSource = movieList;
            searchTextBox.Select();
        }

        private void addMoviesPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostPopularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HumanListForm humanListForm = new HumanListForm();
            humanListForm.gelenSqlString = "SELECT h.*,AVG(ch.point) as humanPoint FROM Human h, CommentsOfHuman ch WHERE (h.h_no=ch.h_no) GROUP BY h.h_no,h.name,h.l_name,h.b_date,h.city,h.country,h.biography, h.height, h.photo, h.sex, h.actorFlag, h.authorFlag, h.directorFlag ORDER BY humanPoint DESC";
            humanListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Human h WHERE EXISTS(SELECT ch.h_no FROM CommentsOfHuman ch WHERE h.h_no=ch.h_no)";
            humanListForm.gelenU_No = user.getU_No();
            humanListForm.Text += " [Most Populer]";
            humanListForm.ShowDialog();
        }

        private void allCelebritiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HumanListForm humanListForm = new HumanListForm();
            humanListForm.gelenSqlString = "SELECT * FROM Human ORDER BY name";
            humanListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Human ";
            humanListForm.gelenU_No = user.getU_No();
            humanListForm.Text += " [A-Z]";
            humanListForm.ShowDialog();
        }

        private void bornTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HumanListForm humanListForm = new HumanListForm();
            humanListForm.gelenSqlString = "SELECT * FROM Human WHERE b_date='" + today + "' ORDER BY name";
            humanListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Human WHERE b_date='" + today + "'";
            humanListForm.gelenU_No = user.getU_No();
            humanListForm.ShowDialog();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesListForm moviesListForm = new MoviesListForm();
            moviesListForm.gelenU_No = user.getU_No();
            moviesListForm.gelenSqlString = "SELECT * FROM Movies ORDER BY name";
            moviesListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Movies";
            moviesListForm.Text += " [A-Z]";
            moviesListForm.ShowDialog();
        }

        private void topRatedMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesListForm movieListForm = new MoviesListForm();
            movieListForm.gelenSqlString = "SELECT m.*,AVG(cm.point) as moviePoint FROM Movies m, CommentsOfMovie cm WHERE (m.m_no=cm.m_no) GROUP BY m.m_no,m.name,m.about,m.release_date,m.budget,m.mtime,m.trailer, m.cover, m.m_language ORDER BY moviePoint DESC";
            movieListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Movies m WHERE EXISTS(SELECT cm.m_no FROM CommentsOfMovie cm WHERE m.m_no=cm.m_no)";
            movieListForm.gelenU_No = user.getU_No();
            movieListForm.Text += " [Top Rated]";
            movieListForm.ShowDialog();
        }

        private void comingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesListForm moviesListForm = new MoviesListForm();
            moviesListForm.gelenU_No = user.getU_No();
            moviesListForm.gelenSqlString = "SELECT * FROM Movies WHERE release_date > '" + today + "'";
            moviesListForm.gelenSqlCountString = "SELECT COUNT(*) FROM Movies WHERE release_date > '" + today + "'";
            moviesListForm.Text += " [Coming Soon]";
            moviesListForm.ShowDialog();
        }

        private void myWatchlistToolStripMenuItem_Click(object sender, EventArgs e)             //// BURADA KALDIM
        {
            WatchListForm watchListForm = new WatchListForm();
            watchListForm.gelenU_No = user.getU_No();
            watchListForm.Text += " [" + user.getName() + "]";
            watchListForm.ShowDialog();
        }

        private void myWatchedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchedListForm watchedListForm = new WatchedListForm();
            watchedListForm.gelenU_No = user.getU_No();
            watchedListForm.Text += " [" + user.getName() + "]";
            watchedListForm.ShowDialog();
        }
    }

    class dbConnect
    {
        private SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        public void openConnect()
        {
            if(con.State==ConnectionState.Closed)
                con.Open();
        }
        public void closeConnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void Command(string sqlString)
        {
            cmd = new SqlCommand(sqlString, con);
            dr = cmd.ExecuteReader();
        }
    }
  
}
