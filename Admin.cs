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
        public override void addClass(ref Class c, bool doAnyway)
        {
            throw new NotImplementedException();
        }
        public override void addClass(Class c)
        {
            throw new NotImplementedException();
        }
        public override void removeClass(Class c) { throw new NotImplementedException(); }

    }
}