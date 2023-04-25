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
                    user = new Student(s[2], s[4], s[3], s[0], s[1], s[5]);

                }
                users.Add(user);
            }



            List<User> list = new List<User>();
           
            foreach(var u in users.ToList())
            {
                if (u.getStatus() == "faculty")
                {
                    Faculty f = (Faculty)u;
                    foreach(User us in users)
                    {
                        if(us.getStatus() == "student")
                        {
                            Student st = (Student)us;
                            if (st.Advisor == f.getUsername())
                            {
                                f.addStudent(st);
                            }
                        }
                    }
                    Console.WriteLine(f.getUsername());
                    f.printAdvisees();
                    users[users.IndexOf(u)] = f; ;
                }
            }
            
            this.lines = File.ReadAllLines(fhistory);
            s.RemoveAll(x => x.Length>0);  //don't think it's neeeded


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
                string Grade;
                double gpaye;
                Student student = null;

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
                    Grade = s[place];
                    place++;
                    
                    foreach (User user in users)
                    {
                        if (user.getUsername() == username)
                        {
                            student = (Student)user;
                        }
                    }
                    // splitting second index
                    char[] dash = new char[] { '-' };
                    string[] classInfo = new string[] { };
                    classInfo = course.Split(dash);
                    gpaye = GpaCalculator(credit,Grade);
                    Class c = new Class(classInfo[0], classInfo[1], classInfo[2], term, credit, Grade,gpaye);
                    student.addClassHistory(c);
                    i++;
                }
                student.calcGPA();
                student.calcCredits();

                ////////////////////////////////////////////////////////////////
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

        public void addUser(User user)
        {
            users.Add(user);
        }
        public void removeUser(User user)
        {
            if (user.getStatus() == "student")
            {
                Student s = (Student)user;
                foreach(Class c in user.classes)
                {
                    c.removeStudent(user);
                }
                Faculty f =(Faculty)users[users.IndexOf(GetUser(s.Advisor))];
                f.removeAdvisee(s);
                users[users.IndexOf(GetUser(s.Advisor))] = f;
            }
            else
            {
                Faculty f = (Faculty)user;
                foreach(Student s in f.Advisees)
                {
                    s.Advisor = "staff";
                }
                foreach(Class c in f.classes)
                {
                    c.Prof = "staff";
                }
                
            }
            users.Remove(user);
        }
        public void PrintUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }
       

        public double GpaCalculator(string credits, string Grade)
        {

            double GPA = 0.0;
            double creed = double.Parse(credits);
            
            if (Grade.Contains("A"))
            {
                GPA = 4.0*creed;
            }
            if (Grade.Contains("A-"))
            {
                GPA = 3.7 * creed;
            }
            if (Grade.Contains("B+"))
            {
                GPA = 3.3 * creed;
            }
            if (Grade.Contains("B"))
            {
                GPA = 3.0 * creed;
            }
            if (Grade.Contains("B-"))
            {
                GPA = 2.7 * creed;
            }
            if (Grade.Contains("C+"))
            {
                GPA = 2.3 * creed;
            }
            if (Grade.Contains("C"))
            {
                GPA = 2.0 * creed;
            }
            if (Grade.Contains("C-"))
            {
                GPA = 1.7 * creed;
            }
            if (Grade.Contains("D+"))
            {
                GPA = 1.3 * creed;
            }
            if (Grade.Contains("D"))
            {
                GPA = 1.0 * creed;
            }
            if (Grade.Contains("D-"))
            {
                GPA = 0.7 * creed;
            }
            if (Grade.Contains("F"))
            {
                GPA = 0.0;
            }
            if (Grade.Contains("WF"))
            {
                GPA = 0.0;
            }
            if (Grade.Contains("U"))
            {
                GPA = 0.0;
            }
            if (Grade.Contains("S"))
            {
                GPA = 0.0;
            }

            return GPA;
        }
        

    }
}

