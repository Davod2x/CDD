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


        public UserDB(string fname, string fhistory)
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
            this.lines = File.ReadAllLines(fhistory);
            List<string> s = new List<string>();  //don't think it's neeeded

            foreach (string line in lines)
            {
                s.RemoveAll(x => x.Length > 0);
                this.strings = line.Split(this.whitespace);
                foreach (string str in strings)
                {
                    if (str.Length > 0)
                        s.Add(str);
                }

                string username = s[0];
                int numCourses = int.Parse(s[1]);

                string course;
                string term;
                string credit;
                string grade;
                Student student;

                int i = 0;
                int place = 2;
                while (i < numCourses)
                {
                    course = s[place];
                    place++;
                    term = s[place];
                    place++;
                    credit = s[place];
                    place++;
                    grade = s[place];
                    place++;
                    foreach (User user in userDB.users)
                    {
                        if (user.getUsername() == username)
                        {
                            student = user;
                        }
                    }
                    // splitting second index
                    char[] dash = new char[] { '-' };
                    string[] classInfo = new string[] { };
                    classInfo = course.Split(dash);

                    Class c = new Class(classInfo[0], classInfo[1], classInfo[2], term, credits, grade);
                    student.addClassHistory(c);
                    i++;
                }
             
            ////////////////////////////////////////////////////////////////
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

