using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Class
    {
        //public string user { get; set; }
        //public int numclasses { get; set; }
        //public string coursename { get; set; }
        public string Term { get; set; }

        public string Grade { get; set; }
        //public string classes { get; set; }
        public string Name { get; set; }
        public string Dpt { get; set; }
        public string ClassNum { get; set; }
        public string Section { get; set; }
        public string Prof { get; set; }
        public string Credits { get; set; }
        public string Seats { get; set; }
        public int SeatsAvail { get; set; }
        //public string TimeBlocks { get; set; }
        public string Days { get; set; }
        public string EndTime { get; set; }
        public string StartTime { get; set; }
        public double Gpa { get; set; }

        public string Course { get; set; }

        public string FormattedTime { get; set; }

        public List<Student> Students { get; set; } 

        public bool Conflict { get; set; }


        public Class(string dpt, string classNum, string section, string name,  string prof, string credits, string seats, string startTime, string endTime, string days)
        {
            this.Dpt = dpt;
            this.Name = name;
            this.ClassNum = classNum;
            this.Section = section;
            this.Prof = prof;
            this.Credits = credits;
            this.Seats = seats;
            this.SeatsAvail = int.Parse(seats);
            this.StartTime = startTime;
            this.Days = days;
            this.EndTime = endTime;
            this.Students = new List<Student>();   
            
            this.Conflict = false;
            
        }
        public Class(string dpt, string classNum, string section, string Term, string credits, string Grade, double gpa)
        {
            this.Dpt = dpt;
            this.ClassNum = classNum;
            this.Section = section;
            this.Credits = credits;
           
            this.Term = Term;
            this.Grade = Grade;
            this.Gpa = gpa;
        }

        public void addStudent(Student s)
        {
            Students.Add(s);

        }
        public void removeStudent(User user)
        {
            Students.Remove((Student)user);
        }
        public void removeAllStudents()
        {
            foreach(Student s in Students)
            {
                s.removeClass(this);
            }
            Students.Clear();
        }

        //public Class(string user, string classes, string coursename,string Term, string credits, string Grade)
        //{
        //    this.user = user;
        //    this.classes = classes;
        //    this.numclasses = int.Parse(classes);
        //    this .coursename = coursename;
        //    this.Term = Term;
        //    this.Credits = credits;
        //    this.Grade = Grade;

        //}

        //(string name,

        public static bool operator ==(Class c1, Class c2)
        {
            return c1.Course == c2.Course;
        }
        public static bool operator !=(Class c1, Class c2) { return !(c1 == c2); }
        public bool Equals(Class c)
        {
            return this.Course == c.Course && this.Grade == c.Grade;
        }
        public override string ToString()
        {
            Course = Dpt + "-" + ClassNum + "-" + Section;
            FormattedTime = StartTime + "-" + EndTime;
            if (Grade == null)
            {
                return Course + " " + Name + " " + Prof + " " + Credits + " " + SeatsAvail + " " + Days + " " + FormattedTime;
            }
            else
            {
                return Course + " " + Term + " " + Credits + " " + Grade + " " + Gpa;
            }
        }

    }

}
