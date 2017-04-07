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
    public partial class HumanListForm : Form
    {

        public string gelenU_No;
        public string gelenSqlString="";
        public string gelenSqlCountString = "";

        public HumanListForm()
        {
            InitializeComponent();
        }
        public void loadList(string sqlString,string sqlCount)
        {

            dbConnect connect = new dbConnect();    //// Buradan
            int humanCount=0;
            connect.openConnect();
            connect.Command(sqlCount);
            connect.dr.Read();
            humanCount = Convert.ToInt32(connect.dr[0].ToString());
            connect.closeConnect();                 //// Buraya kadar Veri tabanındaki kişi sayısını bulduk.
            if(humanCount<1)
            {
                MessageBox.Show("There is no record to show.","Error");
                this.Close();
            }
            Label[] name = new Label[humanCount + 1];// Kişilerin isimlerinin yazılacağı labellar
            Label[] job = new Label[humanCount + 1]; //Kişilerin mesleklerinin yazılacağı labellar
            Label[] biography = new Label[humanCount + 1]; //Kişilerin biographylerinin yazılacağı labellar
            PictureBox[] humanPicture = new PictureBox[humanCount+1];//Kişilerin resimlerinin ekleneceği pictureboxlar

            int humanCounter=0;

            name[humanCounter] = new Label();      
            name[humanCounter].Location = new Point(0, -153);
            name[humanCounter].Size = new Size(0,0);
            name[humanCounter].Name = "HumanListStartPositionLabel";
            mainPanel.Controls.Add(name[humanCounter]);  // kişilerin İsimleri bu labele hizalanacak

            job[humanCounter] = new Label();            // kişilerin meslekleri bu labele hizalanacak
            job[humanCounter].Location = new Point(0, -123);
            job[humanCounter].Size = new Size(0, 0);
            job[humanCounter].Name = "HumanListStartPositionLabel";
            mainPanel.Controls.Add(job[humanCounter]);

            biography[humanCounter] = new Label();            // kişilerin biograpyleri bu labele hizalanacak
            biography[humanCounter].Location = new Point(0, -97);
            biography[humanCounter].Size = new Size(0, 0);
            biography[humanCounter].Name = "HumanListStartPositionLabel";
            mainPanel.Controls.Add(biography[humanCounter]);

            humanPicture[humanCounter] = new PictureBox();            // kişilerin resimleri bu Pictureboxa hizalanacak
            humanPicture[humanCounter].Location = new Point(0, -153);
            humanPicture[humanCounter].Size = new Size(0, 0);
            humanPicture[humanCounter].Name = "HumanListStartPositionLabel";
            mainPanel.Controls.Add(humanPicture[humanCounter]);


            humanCounter++;

            string humanJob="";
            connect.openConnect();
            connect.Command(sqlString);

            while (connect.dr.Read())
            {
                name[humanCounter] = new Label();
                name[humanCounter].Font = new Font("Microsoft Sans Serif", 14,FontStyle.Bold);
                name[humanCounter].ForeColor = Color.Black;
                name[humanCounter].Click += new EventHandler(nameLabel_Click);
                name[humanCounter].Text = connect.dr[1].ToString() + " " + connect.dr[2].ToString();
                name[humanCounter].Location = new Point(122 , name[humanCounter-1].Location.Y + 156);
                name[humanCounter].AutoSize = true;
                name[humanCounter].MaximumSize= new Size(550, 25);
                name[humanCounter].Name = connect.dr[0].ToString()+"@NameLabel";
                mainPanel.Controls.Add(name[humanCounter]);  // kişilerin İsimleri bu labele hizalanacak

                if (connect.dr[10].ToString() == "True")
                {
                    if(connect.dr[9].ToString() == "M")
                        humanJob += "Actor";
                    else
                        humanJob += "Actress";
                }

                if (connect.dr[11].ToString() == "True")
                    humanJob += " Author";

                if (connect.dr[12].ToString() == "True")
                    humanJob += " Director";


                job[humanCounter] = new Label();            // kişilerin meslekleri bu labele hizalanacak
                job[humanCounter].Font = new Font("Microsoft Sans Serif", 12);
                job[humanCounter].ForeColor = Color.Black;
                job[humanCounter].Text = humanJob;
                job[humanCounter].Location = new Point(122, job[humanCounter-1].Location.Y+156);
                job[humanCounter].AutoSize = true;
                job[humanCounter].MaximumSize = new Size(550, 20);
                job[humanCounter].Name = connect.dr[0].ToString() +  "@HumanJobLabel";
                mainPanel.Controls.Add(job[humanCounter]);

                humanJob = "";

                biography[humanCounter] = new Label();  // kişilerin biograpyleri bu labele hizalanacak
                biography[humanCounter].Font = new Font("Microsoft Sans Serif", 10);
                biography[humanCounter].ForeColor = Color.Black;
                biography[humanCounter].Text = connect.dr[6].ToString();
                biography[humanCounter].Location = new Point(122, biography[humanCounter-1].Location.Y + 156);
                biography[humanCounter].AutoSize = true;
                biography[humanCounter].MaximumSize = new Size(550, 85);
                biography[humanCounter].Name = connect.dr[0].ToString() + "@BiographyLabel";
                mainPanel.Controls.Add(biography[humanCounter]);


                humanPicture[humanCounter] = new PictureBox();            // kişilerin resimleri bu Pictureboxa hizalanacak
                humanPicture[humanCounter].Location = new Point(12, humanPicture[humanCounter-1].Location.Y + 156);
                humanPicture[humanCounter].Size = new Size(100,150);
                humanPicture[humanCounter].ImageLocation = connect.dr[8].ToString();
                humanPicture[humanCounter].SizeMode = PictureBoxSizeMode.StretchImage;
                humanPicture[humanCounter].Click += new EventHandler(humanPicture_Click);
                humanPicture[humanCounter].Name = connect.dr[0].ToString() + "@humanPictureBox";
                mainPanel.Controls.Add(humanPicture[humanCounter]);



                humanCounter++;


            }
        }
        private void humanPicture_Click(object sender, EventArgs e)
        {
            string h_no = "";
            PictureBox ogren = sender as PictureBox;
            h_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = h_no;
            detailHuman.gelenU_No = gelenU_No;
            detailHuman.ShowDialog();
        }
        private void nameLabel_Click(object sender, EventArgs e)
        {
            string h_no="";
            Label ogren = sender as Label;
            h_no = ogren.Name.Substring(0, ogren.Name.IndexOf("@"));
            DetailsHumanForm detailHuman = new DetailsHumanForm();
            detailHuman.gelenH_No = h_no;
            detailHuman.gelenU_No =gelenU_No;
            detailHuman.ShowDialog();

            
        }
        
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

            searchTextBox.AutoCompleteCustomSource = humanList;

        }
        private void HumanListForm_Load(object sender, EventArgs e)
        {
            mainPanel.Select();
            loadList(gelenSqlString, gelenSqlCountString);
            loadSearchText();
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {
            mainPanel.Select();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            string sqlString = "";
            con.Open();
            sqlString = "SELECT h_no,name,l_name FROM Human WHERE name=@name AND l_name=@l_name";
            cmd = new SqlCommand(sqlString, con);
            string name, lname;
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
                detailHuman.gelenU_No = gelenU_No;
                detailHuman.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aradığınız kişi bulunamadı.","Error");
            }
            con.Close();
        }
    }
}
