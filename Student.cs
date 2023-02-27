using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class Student : User
    {

        int currentClassesNum;
        double gpaEarned;
        int totalClassesTaken;

        public Student(string fname, string lname, string mname, string username, string password)
            : base(fname, lname, mname, username, password)
        {
            this.currentClassesNum = 0; // still need to increment in the add function, as well as take away an available seat in the class
            this.gpaEarned = 0.0;
            this.totalClassesTaken = 0;
            this.status = "student";
            this.classes = new List<Class>();
            this.classHistory = new List<Class>();
        }

        public override void addClass(Class c)
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
            if (!taking && !conflict && currentClassesNum <= 5) {
                classes.Add(c);
                currentClassesNum++;
                c.SeatsAvail--;
            }
            else if (currentClassesNum > 5)
            {
                throw new InvalidOperationException("Schedule Overload & Time Conflict");
            }
            else if (conflict || taking)
            {
                throw new InvalidDataException("");
            }


        }



        public override void removeClass(Class c)
        {
            classes.Remove(c);
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
                if (c.grade.Equals("A"))
                {
                    gpaEarned = gpaEarned+4.0;
                }
                if (c.grade.Equals("A-"))
                {
                    gpaEarned = gpaEarned+3.7;
                }
                if (c.grade.Equals("B+"))
                {
                    gpaEarned = gpaEarned + 3.3;
                }
                if (c.grade.Equals("B"))
                {
                    gpaEarned = gpaEarned + 3.0;
                }
                if (c.grade.Equals("B-"))
                {
                    gpaEarned = gpaEarned + 2.7;
                }
                if (c.grade.Equals("C+"))
                {
                    gpaEarned = gpaEarned + 2.3;
                }
                if (c.grade.Equals("C"))
                {
                    gpaEarned = gpaEarned + 2.0;
                }
                if (c.grade.Equals("C-"))
                {
                    gpaEarned = gpaEarned + 1.7;
                }
                if (c.grade.Equals("D+"))
                {
                    gpaEarned = gpaEarned + 1.3;
                }
                if (c.grade.Equals("D"))
                {
                    gpaEarned = gpaEarned + 1.0;
                }
                if (c.grade.Equals("D-"))
                {
                    gpaEarned = gpaEarned + 0.7;
                }
                // 
                if (c.grade.Equals("F") || c.grade.Equals("WF"))
                {
                    gpaEarned = gpaEarned + 0.0;
                }
                totalCredits = totalCredits + double.Parse(c.Credits);
            }
            this.gpaEarned = gpaEarned / totalCredits;
       
            // access credits from class, update 
        }
    }

    /////////////////////////
    }



