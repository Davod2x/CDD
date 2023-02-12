﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class UserDB : RS
    {
        
        public List<User> users;
        private char[] whitespace = new char[] { ' ', '\t' };
        

        public UserDB(string fname) {
            string[] lines = File.ReadAllLines(fname);
            this.users = new List<User>();
            List<string> s = new List<string>();
        
                foreach (string line in lines) {
                    s.RemoveAll(x => x.Length > 0);
                    string[] strings= line.Split(whitespace);
                    foreach (string str in strings)
                    {
                    if (str.Length > 0) 
                        s.Add(str);
                    }
                    User user = new User(s[2], s[4], s[3], s[5], s[0], s[1],"0000");
                    users.Add(user);
            }
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
        public void PrintUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }


    }
}
