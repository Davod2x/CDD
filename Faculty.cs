﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Faculty : User

    {
        public List<Student> Advisees { get; set; }
        public Faculty(string fname, string lname, string mname, string username, string password)
            : base(fname, lname, mname, username, password)
        {
            this.Advisees = new List<Student>();
            this.status = "faculty";
            this.classes = new List<Class>();

        }
        public override void addClass(Class c)
        {
            classes.Add(c);
        }
        public override void addClass(ref Class c, bool doAnyway)
        {
            throw new NotImplementedException();
        }
        public override void removeClass(Class c) { classes.Remove(c); }

        public void removeAdvisee(Student s)
        {
            Advisees.Remove(s);
        }

        public void viewStudents()
        {
            foreach (Class cl in classes)
            {
                foreach (Student student in cl.Students)
                {
                    Console.WriteLine(student.getUsername());
                }
            }
        }
       
        public void addStudent(Student student)
        {
            Advisees.Add(student);
        }

        public void printAdvisees()
        {
            foreach(Student s in Advisees)
            {
                Console.WriteLine(s.getUsername());
            }
        }
    }

}
