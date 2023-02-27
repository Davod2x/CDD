using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal abstract class User
    {
        protected string fname;
        protected string lname;
        protected string mname;
        protected string status;
        protected string username;
        protected string password;
        public List<Class> classes { get; set; }
        public List<Class> classHistory{get;set;}



        public User(string fname, string lname, string mname, string username,
                    string password)
        {
            this.fname = fname;
            this.lname = lname;
            this.mname = mname;
            this.status = "";
            this.username = username;
            this.password = password;
            

        }

        public string getfName()
        {
            return fname;
        }
        public void setfName(string name)
        {
            fname = name;
        }

        public string getlName()
        {
            return lname;
        }
        public void setlName(string name)
        {
            lname = name;
        }

        public string getmName()
        {
            return mname;
        }
        public void setmName(string name)
        {
            mname = name;
        }

        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status)
        {
            if (status == "a")
            {
                this.status = "a";
            }
            else if (status == "f")
            {
                this.status = "f";
            }
            else if (status == "s")
            {
                this.status = "s";
            }
            else
            {
                Console.WriteLine("You provided an invalid status. Valid status inldudes: 'a' , 'f', or 's'.");
            }
        }
        public string getUsername()
        {
            return username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public override string ToString()
        {
            return this.getfName() + this.getmName() + this.getlName() + this.getUsername() + this.getPassword();
        }

        public abstract void addClass(Class c);  // children classes decide functionality

        public abstract void removeClass(Class c);
    }
}
