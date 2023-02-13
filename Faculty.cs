﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Faculty : User
    {
        public Faculty(string fname, string lname, string mname, string username, string password)
            : base(fname, lname, mname, username, password)
        {
            this.status = "faculty";

        }

    }
}