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
    public partial class MoviesListForm : Form
    {

        public string gelenU_No="";
        public string gelenSqlString = "";
        public string gelenSqlCountString = "";

        public MoviesListForm()
        {
            InitializeComponent();
        }

        public void loadList(string sqlString, string sqlCount)
        {

            dbConnect connect = new dbConnect();
            dbConnect connectForType = new dbConnect();  
            int movieCount = 0;
            connect.openConnect();
            connect.Command(sqlCount);
            connect.dr.Read();
            movieCount = Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();                
            if (movieCount < 1)
            {
                MessageBox.Show("There is no record to show.", "Error");
                this.Close();
            }
            Label[] name = new Label[movieCount + 1];
            Label[] type = new Label[movieCount + 1]; 
            Label[] about = new Label[movieCount + 1];
            PictureBox[] movieCover = new PictureBox[movieCount + 1];

            int movieCounter = 0;
           
            name[movieCounter] = new Label();
            name[movieCounter].Location = new Point(0, -153);
            name[movieCounter].Size = new Size(0, 0);
            name[movieCounter].Name = "MovieListStartPositionLabel";
            mainPanel.Controls.Add(name[movieCounter]);


            type[movieCounter] = new Label();
            type[movieCounter].Location = new Point(0, -123);
            type[movieCounter].Size = new Size(0, 0);
            type[movieCounter].Name = "MovieListStartPositionLabel";
            mainPanel.Controls.Add(type[movieCounter]);


            about[movieCounter] = new Label();           
            about[movieCounter].Location = new Point(0, -97);
            about[movieCounter].Size = new Size(0, 0);
            about[movieCounter].Name = "MovieListStartPositionLabel";
            mainPanel.Controls.Add(about[movieCounter]);

            movieCover[movieCounter] = new PictureBox();            
            movieCover[movieCounter].Location = new Point(0, -153);
            movieCover[movieCounter].Size = new Size(0, 0);
            movieCover[movieCounter].Name = "MovieListStartPositionLabel";
            mainPanel.Controls.Add(movieCover[movieCounter]);


            movieCounter++;

            string movieType = "";
            connect.openConnect();
            connect.Command(sqlString);

            while (connect.dr.Read())
            {
                name[movieCounter] = new Label();
                name[movieCounter].Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                name[movieCounter].ForeColor = Color.Black;
                name[movieCounter].Click += new EventHandler(nameLabel_Click);
                name[movieCounter].Text = connect.dr[1].ToString();
                name[movieCounter].Location = new Point(122, name[movieCounter - 1].Location.Y + 156);
                name[movieCounter].AutoSize = true;
                name[movieCounter].MaximumSize = new Size(550, 25);
                name[movieCounter].Name = connect.dr[0].ToString() + "@NameLabel";
                mainPanel.Controls.Add(name[movieCounter]);  // kişilerin İsimleri bu labele hizalanacak


                connectForType.openConnect();
                connectForType.Command("SELECT t.name FROM Movies m, Types t, TypeOfMovie tm WHERE m.m_no = '" + connect.dr[0].ToString() + "' AND(m.m_no = tm.m_no) AND (tm.t_no = t.t_no)");
                while (connectForType.dr.Read())
                {
                    movieType += connectForType.dr[0].ToString() + " ";
                }
                connectForType.closeConnect();

                type[movieCounter] = new Label();            
                type[movieCounter].Font = new Font("Microsoft Sans Serif", 12);
                type[movieCounter].ForeColor = Color.Black;
                type[movieCounter].Text = movieType;
                type[movieCounter].Location = new Point(122, type[movieCounter - 1].Location.Y + 156);
                type[movieCounter].AutoSize = true;
                type[movieCounter].MaximumSize = new Size(550, 20);
                type[movieCounter].Name = connect.dr[0].ToString() + "@MovieTypeLabel";
                mainPanel.Controls.Add(type[movieCounter]);

                movieType = "";
                about[movieCounter] = new Label();  
                about[movieCounter].Font = new Font("Microsoft Sans Serif", 10);
                about[movieCounter].ForeColor = Color.Black;
                about[movieCounter].Text = connect.dr[2].ToString();
                about[movieCounter].Location = new Point(122, about[movieCounter - 1].Location.Y + 156);
                about[movieCounter].AutoSize = true;
                about[movieCounter].MaximumSize = new Size(550, 85);
                about[movieCounter].Name = connect.dr[0].ToString() + "@aboutLabel";
                mainPanel.Controls.Add(about[movieCounter]);


                movieCover[movieCounter] = new PictureBox();            // kişilerin resimleri bu Pictureboxa hizalanacak
                movieCover[movieCounter].Location = new Point(12, movieCover[movieCounter - 1].Location.Y + 156);
                movieCover[movieCounter].Size = new Size(100, 150);
                movieCover[movieCounter].ImageLocation = connect.dr[7].ToString();
                movieCover[movieCounter].SizeMode = PictureBoxSizeMode.StretchImage;
                movieCover[movieCounter].Click += new EventHandler(movieCover_Click);
                movieCover[movieCounter].Name = connect.dr[0].ToString() + "@humanPictureBox";
                mainPanel.Controls.Add(movieCover[movieCounter]);

                movieCounter++;


            }
        }

        AutoCompleteStringCollection movieList = new AutoCompleteStringCollection();
        public void loadSearchText()
        {

            dbConnect baglan = new dbConnect();
            baglan.openConnect();
            string sqlString = "SELECT name, m_no FROM Movies";
            baglan.Command(sqlString);
            while (baglan.dr.Read())
            {
                movieList.Add(baglan.dr[0].ToString());
            }
            baglan.closeConnect();
            searchTextBox.AutoCompleteCustomSource = movieList;

        }
        private void movieCover_Click(object sender, EventArgs e)
        {
            string m_no = "";
            PictureBox ogren = sender as PictureBox;
            m_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsMovieForm detailHuman = new DetailsMovieForm();
            detailHuman.gelenM_No = m_no;
            detailHuman.gelenU_No = gelenU_No;
            detailHuman.ShowDialog();
        }
        private void nameLabel_Click(object sender, EventArgs e)
        {
            string m_no = "";
            Label ogren = sender as Label;
            m_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsMovieForm detailHuman = new DetailsMovieForm();
            detailHuman.gelenM_No = m_no;
            detailHuman.gelenU_No = gelenU_No;
            detailHuman.ShowDialog();

        }

        private void MoviesListForm_Load(object sender, EventArgs e)
        {
            mainPanel.Select();
            loadList(gelenSqlString, gelenSqlCountString);
            loadSearchText();

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string sqlString = "";
            con.Open();
           
            
                sqlString = "SELECT m_no,name FROM Movies WHERE name=@name";
                cmd = new SqlCommand(sqlString, con);

                cmd.Parameters.AddWithValue("@name", searchTextBox.Text);
                dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    DetailsMovieForm detailMovie = new DetailsMovieForm();
                    detailMovie.gelenM_No = dr[0].ToString();
                    detailMovie.gelenU_No = gelenU_No;
                    detailMovie.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Aradığınız film bulunamadı.");
                }
                con.Close();
            
        }
    }
}
