using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class ClassDB
    {
        public List<Class> classes;
        private char[] whitespace;
        private string[] lines;
        private string[] strings;

        public Class(float name, float prof, int days, float time, float Ntime)
        {

            foreach (string line in lines)
            {
                s.RemoveAll(x => x.Length > 0);
                this.strings = line.Split(this.whitespace);
                foreach (string str in strings)
                {
                    if (str.Length > 0)
                        s.Add(str);
                }
                string fancyName = s[0];
                int loc = 1;
                int realLoc = 1;
                string courseName = "";
                string realCourseName = "";
                bool inUsers = false;
                string last = "";
                //while (loc < s.Count && !inUsers)
                //{
                foreach (User user in userDB.users)
                {
                    courseName = "";
                    loc = 1;
                    while (loc < s.Count && !inUsers)
                    {
                        if (s[loc] != user.getUsername())
                        {
                            courseName = courseName + s[loc] + " ";
                        }
                        else
                        {
                            inUsers = true;
                            realCourseName = courseName;
                            realLoc = loc;

                        }
                        loc++;
                    }
                }
                string times= "";
                int place = loc + 4;
                while (place < s.Count)
                {
                    times = times + s[place] + " ";
                    place++;
                }
                Class c = new Class(s[0], realCourseName, s[realLoc], s[realLoc+1], int.Parse(s[realLoc+2]), s[realLoc+3], times);
                classes.Add(c);
            }
        }


        public int dayConversion(int days)
        {

            if (days / 16 >= 1)
            {
                Console.Out.WriteLine("Friday");
                days = days - 16;
            }
            if (days / 8 >= 1)
            {
                Console.Out.WriteLine("Thursday");
                days = days - 8;
            }
            if (days / 4 >= 1)
            {
                Console.Out.WriteLine("Wednesday");
                days = days - 4;
            }
            if (days / 2 >= 1)
            {
                Console.Out.WriteLine("Tuesday");
                days = days - 2;
            }
            if (days / 1 >= 1)
            {
                Console.Out.WriteLine("Monday");
                days = days - 1;
            }

            return days;
        }

        public float timeConversion(float time)
        {
            float ntime;
          
            if (time >= 12 )
            {
               
                if (time == 12)
                {
                    ntime = 12;
                }
                else
                {
                    ntime = time - 12;
                }
                Console.Out.WriteLine("PM");
            }

            else
            {
                ntime = time;
                Console.Out.WriteLine("AM");
            }



            return ntime;
        }
        public void lengthConvo(int len)
        {
            if (len == 2)
            {
                Console.Out.WriteLine("1 hour long");
            }
            if (len == 3)
                Console.Out.WriteLine("1.5 hour long");



        }
        public void PrintUsers()
        {
            foreach (Class c in classes)
            {
                Console.WriteLine(c.ToString());
            }
        }



    }
}




