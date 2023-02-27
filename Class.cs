using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Class
    {
        //public string user { get; private set; }
        //public int numclasses { get; set; }
        //public string coursename { get; private set; }
        public string term { get; private set; }
        public string grade { get; private set; }
        //public string classes { get; private set; }
        public string Name { get; private set; }
        public string Dpt { get; private set; }
        public string ClassNum { get; private set; }
        public string Section { get; private set; }
        public string Prof { get; private set; }
        public string Credits { get; private set; }
        public string Seats { get; private set; }
        public int SeatsAvail { get; set; }
        public string TimeBlocks { get; private set; }
        public string Days { get; private set; }
        public string EndTime { get; private set; }
        public string StartTime { get; private set; }

        public string Course { get; private set; }

        public string FormattedTime { get; private set; }



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
            
            Course = Dpt + "-"+ classNum+ "-"+ section;
            FormattedTime = StartTime+ "-" + EndTime;

            this.term = null;
            this.grade = null;
        }
        public Class(string dpt, string classNum, string section, string term, string credits, string grade)
        {
            this.Dpt = dpt;
            this.Name = null;
            this.ClassNum = classNum;
            this.Section = section;
            this.Prof = null;
            this.Credits = credits;
            this.Seats = null;
            this.SeatsAvail = null;
            this.Days = null;
            this.EndTime = null;
            Course = Dpt + "-" + classNum + "-" + section;
            FormattedTime = null;
            this.term = term;
            this.grade = grade;
        }

        //public Class(string user, string classes, string coursename,string term, string credits, string grade)
        //{
        //    this.user = user;
        //    this.classes = classes;
        //    this.numclasses = int.Parse(classes);
        //    this .coursename = coursename;
        //    this.term = term;
        //    this.Credits = credits;
        //    this.grade = grade;

        //}

        //(string name,

        public static bool operator ==(Class c1, Class c2)
        {
            return c1.Course == c2.Course;
        }
        public static bool operator !=(Class c1, Class c2) { return !(c1 == c2); }
        public override string ToString()
        {
            return this.Course + " " + this.Name + " " + this.Prof + " " + this.Credits + " " + this.Seats + " " + this.Days + " " + this.FormattedTime ;
        }
    }

}
