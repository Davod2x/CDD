﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Student : User
    {
        
        public Student(string fname, string lname, string mname, string username, string password)
            : base(fname, lname, mname, username, password)
        {
            this.status = "student";
            classes = new List<Class>();
        }

        public override void addClass(Class c)
        {
            classes.Add(c);
        }
        
    }
}

