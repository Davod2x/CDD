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

        public List<User> users;
        private char[] whitespace;
        private string[] lines;
        private string[] strings;


        public UserDB(string fname)
        {
            this.lines = File.ReadAllLines(fname);
            this.users = new List<User>();
            this.whitespace = new char[] { ' ', '\t' };
            List<string> s = new List<string>();

            foreach (string line in lines)
            {
                s.RemoveAll(x => x.Length > 0);
                this.strings = line.Split(this.whitespace);
                foreach (string str in strings)
                {
                    if (str.Length > 0)
                        s.Add(str);
                }
                User user;
                if (s[5] == "admin")
                {
                    user = new Admin(s[2], s[4], s[3], s[0], s[1]);
                }
                else if (s[5] == "faculty")
                {
                    user = new Faculty(s[2], s[4], s[3], s[0], s[1]);
                }
                else
                {
                    user = new Student(s[2], s[4], s[3], s[0], s[1]);
                }
                users.Add(user);
            }

            // iterate through history file

        }
        public bool validCredentials(string username, string password)
        {
            bool valid = false;
            foreach (User user in this.users)
            {
                if (user.getUsername().Equals(username) && user.getPassword().Equals(password))
                {
                    valid = true;
                }
            }
            return valid;
        }
        public User GetUser(string username)
        {
            User desired = null;
            foreach (User user in this.users)
            {
                if (user.getUsername().Equals(username))
                {
                    desired = user;
                }
            }
            return desired;
        }

        private void addUser(User user)
        {
            users.Add(user);
        }
        private void removeUser(User user)
        {
            users.Remove(user);
        }
        public void PrintUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }


    }
}

