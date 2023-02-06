using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class UserDB
    {
        private FileStream file;
        List<User> users;
        private char[] whitespace = new char[] { ' ', '\t' };
        
        public UserDB(string fname) {
        string[] lines = File.ReadAllLines(fname);
      
        foreach (string line in lines) {
                this.users = new List<User>();
                string[] Strings = line.Split(whitespace);
                User user = new User(Strings[2], Strings[4], Strings[3], Strings[5], Strings[0], Strings[1], "00000");
                this.users.Add(user);
        }
        }
        private void addUser(User user)
        {
            users.Add(user);
        }


    }
}
