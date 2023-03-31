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

        public void addSpecialClass(ref Class c, bool doAnyway, ref Student s)
        {
            bool previous = false;
            foreach (Class cl1 in s.classHistory)
            {
                if (cl1 == c)
                {
                    previous = true;
                }
            }

            string Grade = "N";
            if (previous)
            {
                Grade = "RN";
            }

            Class cl = new Class(c.Dpt, c.ClassNum, c.Section, "S23", c.Credits, Grade, 0.0);
            s.addClassHistory(cl);
            s.classes.Add(c);
            c.addStudent(s);
            s.currentClassesNum++;



        }
        public void ChangeClassFac(ref Class c, ref Faculty f1, ref Faculty f2)
        {
            c.Prof = f1.getUsername();
            f1.addClass(c);
            f2.removeClass(c);


        }
        public void ChangeClassTime(ref Class c, string endt, string startT)
        {
            c.StartTime = startT;
            c.EndTime = endt;
        }
    }


}