using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    public class User
    {
        public string role;
        public string login;
        public string pswd;
        public static List<User> usersList = new List<User>();
        public User(string login, string pswd, string role)
        {
            this.login = login;
            this.pswd = pswd;
            this.role = role;
            usersList.Add(this); 
        }
    }
}
