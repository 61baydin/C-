using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Project
{
    class Movies
    {
        private string m_no;
        private string name;
        private string about;
        private DateTime release_date;
        private string budget;
        private string mtime;
        private string trailer;
        private string cover;
        private string m_language;
        private string movieTypes = "";
        private string directors;
        private string authors;
        private string leadingRoles;

        public void setLeadingRoles(string value)
        {
            leadingRoles = leadingRoles + value + ", ";
        }

        public void setAuthors(string value)
        {
            authors = authors + value + ", ";
        }

        public void setDirectors(string value)
        {
            directors = directors + value + ", ";
        }
        public void setMovieTypes(string value)
        {
            movieTypes = movieTypes + value + " ";
        }

        public void setValues(string m_no, string name, string about, DateTime release_date, string budget, string mtime, string trailer, string cover, string m_language)
        {
            this.m_no = m_no;
            this.name = name;
            this.about = about;
            this.release_date = release_date;
            this.budget = budget;
            this.mtime = mtime;
            this.trailer = trailer;
            this.cover = cover;
            this.m_language = m_language;
        }
        public string getM_no()
        {
            return m_no;
        }

        public string getName()
        {
            return name;
        }
        public string getAbout()
        {
            return about;
        }
        public DateTime getRelease_date()
        {
            return release_date;
        }
        public string getBudget()
        {
            return budget;
        }
        public string getMtime()
        {
            return mtime + " dk";
        }

        public string getTrailer()
        {
            return trailer;
        }
        public string getCover()
        {
            return cover;
        }
        public string getM_language()
        {
            return m_language;
        }
        public string getMovieType()
        {
            return movieTypes;
        }
        public string getDirectors()
        {
            return directors;
        }
        public string getAuthors()
        {
            return authors;
        }
        public string getLeadingRoles()
        {
            return leadingRoles;
        }
    }
}
