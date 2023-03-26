using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CDD
{
    internal class Student : User
    {
        double creditsEarned;
        double creditsAttempted;
        int currentClassesNum;
        public double gpaEarned {get; private set;}
        int totalClassesTaken;
        public string Advisor { get; private set;}
        public bool ScheduleApproved { get; set; }
        public Student(string fname, string lname, string mname, string username, string password, string advisor)
            : base(fname, lname, mname, username, password)
        {
            this.currentClassesNum = 0; // still need to increment in the add function, as well as take away an available seat in the class
            this.gpaEarned = 0.0;
            this.totalClassesTaken = 0;
            this.status = "student";
            this.Advisor= advisor;
            this.classes = new List<Class>();
            this.classHistory = new List<Class>();
            this.gpaEarned = 0;
            creditsEarned = 0;
            creditsAttempted = 0;
            this.ScheduleApproved= false;
        }

        public override void addClass(ref Class c, bool doAnyway)
        {
            bool taking = false;
            bool conflict = false;
            if (this.classes.Count > 0)
            {
                foreach (Class cl in classes)
                {
                    if (cl == c)
                    {
                        taking = true;
                    }
                    else if (c.StartTime == cl.StartTime)
                    {
                        foreach (char x in cl.Days)
                        {
                            if (c.Days.Contains(x))
                            {
                                conflict = true;
                            }
                        }
                    }
                }
            }
            bool previous = false;
            foreach (Class cl in this.classHistory)
            {
                if (cl == c)
                {
                    previous = true;
                }
            }
            if (currentClassesNum >=5)
            {
                throw new InvalidOperationException("Schedule Overload & Time Conflict");
            }
            else if (conflict || taking)
            {
                throw new InvalidOperationException();
            }
            else if (previous && !doAnyway)
            {
                throw new InvalidOperationException() ;
            }
            else
            {
                string grade = "N";
                if (previous)
                {
                    grade = "RN";
                }
                
                Class cl = new Class(c.Dpt, c.ClassNum, c.Section, "S23", c.Credits, grade, 0.0);
                addClassHistory(cl);
                classes.Add(c);
                c.addStudent(this);
                currentClassesNum++;
                c.SeatsAvail--;
            }
          


        }
        public void removeClassHistory(Class c)
        {

            classHistory.Remove(c);
        }


        public override void removeClass(Class c)
        {
            Class cl = null;
            classes.Remove(c);
            foreach(Class cl2 in this.classHistory)
            {   
                if(cl2 == c && cl2.grade.Contains("N"))
                {
                    cl = cl2;
                }
            }
            this.classHistory.Remove(cl); 
            currentClassesNum--;
            c.SeatsAvail++;
        }


        public bool verifyTimes()
        {
            bool conflict = true;
            foreach (Class cl in classes)
            {
                foreach (Class c in classes)
                {
                    if (c.StartTime == cl.StartTime)
                    {
                        foreach (char x in cl.Days)
                        {
                            if (c.Days.Contains(x))
                            {
                                conflict = true;
                            }
                        }
                    }
                }
            }
            return conflict;
        }

        public void addClassHistory(Class c)
        {

            classHistory.Add(c);

        }
        
        public void printClassHistory() {
            foreach (Class c in this.classHistory)
            {
                System.Console.WriteLine(c.ToString());
            }
        }

        public void calcGPA()
        {
            double gpaEarned=0.0;
            double totalCredits = 0.0;
            foreach (Class c in this.classHistory)
            {
                if (c.grade != "N" || c.grade !="S")
                {
                    gpaEarned += c.Gpa;
                    totalCredits += double.Parse(c.Credits);
                }
            }
            this.gpaEarned = gpaEarned / totalCredits;
       
            // access credits from class, update 
        }

        public void calcCredits()
        {
            double credits=0;
            foreach (Class c in this.classHistory)
            {
                if (c.grade != "N")
                {
                    credits += double.Parse(c.Credits);
                }
            }
            this.creditsEarned= credits;

            // access credits from class, update 
        }

        public double totalCredits()
        {
            double totalCredits = 0.0;
            foreach (Class c in this.classHistory)
            {
                if (c.grade != "N")
                {
                    totalCredits += double.Parse(c.Credits);
                }
            }
            return totalCredits;
        }

        public override void addClass(Class c)
        {
            throw new NotImplementedException();
        }
    }

    /////////////////////////
    }



