using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class User 
    {
        private string fname;
        private string lname;
        private string mname;
        private string status;
        private string username;        
        private string password;
        private string id;


        public User(string fname,string lname, string mname, string status, string username,
                    string password, string id)
        {
            this.fname = fname;
            this.lname = lname;
            this.mname = mname;
            this.status = status;
            this.username = username;
            this.password = password;
            this.id = id;

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

        public string getid()
        {
            return id;
        }
        public void setid(string num)
        {
            id = num;
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

        public abstract void Prompt();  // children classes decide functionality
    }
    
}
