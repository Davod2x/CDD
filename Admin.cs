using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Admin : User
    {
        public Admin(string fname, string lname, string mname, string username, string password)
            : base(fname, lname, mname, username, password)
        {
            this.status = "admin";

        }

    }
}