using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Project
{
    class User
    {
        private string u_no;
        private string name;
        private string email;
        private string pass;
        private bool isAdmin;

        public void setValue(string u_no, string name, string email, string pass, bool isAdmin)
        {
            this.u_no = u_no;
            this.name = name;
            this.email = email;
            this.pass = pass;
            this.isAdmin = isAdmin;
        }
        public string getU_No()
        {
            return u_no;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public string getpass()
        {
            return pass;
        }
        public bool getIsAdmin()
        {
            return isAdmin;
        }

    }
}
