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


        public ClassDB(string fname, UserDB userDB)
        {
            this.lines = File.ReadAllLines(fname);
            this.classes = new List<Class>();
            this.whitespace = new char[] { ' ', '\t' };
            List<string> s = new List<string>();

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
                string courseName = "";
                bool inUsers = false;
                while (loc < s.Count && !inUsers)
                {
                    foreach (User user in userDB.users)
                    {
                        if (s[loc] != user.getUsername())
                        {
                            courseName = courseName + s[loc] + " ";
                        }
                        else
                            inUsers = true;
                    }
                    loc++;
                }
                string times= "";
                int place = loc + 4;
                while (place < s.Count)
                {
                    times = times + s[place] + " ";
                    place++;
                }
                Class c = new Class(s[0], courseName, s[loc], int.Parse(s[loc+1]), int.Parse(s[loc+2]), s[loc+3], times);
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






    }
}




