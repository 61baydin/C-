using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Project
{

    class Human
    {
        private string h_no;
        private string name;
        private string l_name;
        private DateTime b_date;
        private string city;
        private string country;
        private string biography;
        private string height;
        private string photo;
        private char sex;
        private bool actorFlag;
        private bool authorFlag;
        private bool directorFlag;
        public void setValues
            (string h_no, string name, string l_name, DateTime b_date, string city,
            string country, string biography, string height, string photo,
            char sex, bool actorFlag, bool authorFlag, bool directorFlag)
        {
            this.h_no = h_no;
            this.name = name;
            this.l_name = l_name;
            this.b_date = b_date;
            this.city = city;
            this.country = country;
            this.biography = biography;
            this.height = height;
            this.photo = photo;
            this.sex = sex;
            this.actorFlag = actorFlag;
            this.authorFlag = authorFlag;
            this.directorFlag = directorFlag;
        }
        public void setTopCelebInfo(string h_no, string name, string l_name, string photo)
        {
            this.h_no = h_no;
            this.name = name;
            this.l_name = l_name;
            this.photo = photo;

        }
        public string getH_no()
        {
            return h_no;
        }
        public string getName()
        {
            return name;
        }
        public string getL_name()
        {
            return l_name;
        }
        public DateTime getB_date()
        {
            return b_date;
        }
        public string getCity()
        {
            return city;
        }
        public string getCountry()
        {
            return country;
        }
        public string getBiography()
        {
            return biography;
        }
        public string getHeight()
        {
            return height;
        }
        public string getPhoto()
        {
            return photo;
        }
        public string getSex()
        {
            if (sex == 'F')
                return "Female";
            else
                return "Male";

        }
        public bool getActorFlag()
        {
            return actorFlag;
        }
        public bool getAuthorFlag()
        {
            return authorFlag;
        }
        public bool getDirectorFlag()
        {
            return directorFlag;
        }
        public string getJobs()
        {
            string job = "";
            if (getActorFlag())
            {
                if (sex == 'M')
                    job = "Actor";
                else
                    job = "Actress";
            }
            if (getAuthorFlag())
            {
                job += " Author";
            }
            if (getDirectorFlag())
            {
                job += " Director";
            }
            return job;
        }
        public string insertHumanDb()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=IMDB_DB;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            string sqlString = "INSERT INTO Human (h_no,name,l_name,b_date,city,country,biography,height,photo,sex,actorFlag,authorFlag,directorFlag) " +
              "VALUES(@h_no,@name,@l_name,@b_date,@city,@country,@biography,@height,@photo,@sex,@actorFlag,@authorFlag,@directorFlag)";

            cmd = new SqlCommand(sqlString, con);
            cmd.Parameters.AddWithValue("@h_no", this.getH_no());
            cmd.Parameters.AddWithValue("@name", this.getName());
            cmd.Parameters.AddWithValue("@l_name", this.getL_name());
            cmd.Parameters.AddWithValue("@b_date", this.getB_date());
            cmd.Parameters.AddWithValue("@city", this.getCity());
            cmd.Parameters.AddWithValue("@country", this.getCountry());
            cmd.Parameters.AddWithValue("@biography", this.getBiography());
            cmd.Parameters.AddWithValue("@height", this.getHeight());
            cmd.Parameters.AddWithValue("@photo", this.getPhoto());

            char gender;
            if (this.getSex() == "Female")
                gender = 'F';
            else
                gender = 'M';

            cmd.Parameters.AddWithValue("@sex", gender);
            cmd.Parameters.AddWithValue("@actorFlag", this.getActorFlag());
            cmd.Parameters.AddWithValue("@authorFlag", this.getAuthorFlag());
            cmd.Parameters.AddWithValue("@directorFlag", this.getDirectorFlag());

            cmd.ExecuteNonQuery();
            con.Close();
            return "Eklendi.";

        }

    }

}
