using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    class User
    {
        private string userNo;
        private string name;
        private string email;
        private string pass;
        private bool isAdmin;

        public User()
        {
            this.userNo = "";
            this.name = "";
            this.email = "";
            this.pass = "";
            this.isAdmin = false;
        }
        public void setUserValues(string userNo, string name, string email, string pass, bool isAdmin)
        {
            this.userNo = userNo;
            this.name = name;
            this.email = email;
            this.pass = pass;
            this.isAdmin = isAdmin;
        }
        public string getUserNo()
        {
            return userNo;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPass()
        {
            return pass;
        }
        public bool getIsAdmin()
        {
            return isAdmin;
        }

    }
}
