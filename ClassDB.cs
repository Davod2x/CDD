
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
                s.RemoveAll(i => i.Length > 0);
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
                // splitting first index
                char[] dash = new char[] { '-' };
                string[] classInfo = new string[] { };
                classInfo= s[0].Split(dash);
                
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
                            courseName = courseName + s[loc];
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
                //string times = "";
                int place = realLoc + 4;
                string prof = s[realLoc];
                while (place < s.Count)
                {
                    string times = "";
                    times = s[place]; // make this .add to an array
                    string x = times.Substring(0, 2);
                    string y = times.Substring(2, 2);
                    string z = times.Substring(times.Length - 1, 1);
                    int d = int.Parse(x);
                    int t = int.Parse(y);
                    int m = int.Parse(z);
                    string days = dayConversion(d);
                    string timee = timeConversion(t);
                    int a = m + t;
                    string endtime = timeConversion(a);
                    string formattedTime = timee + "-" + endtime;




                    //string numTimes = s[loc + 3]; //Timeblocks

                    Class c = new Class(classInfo[0], classInfo[1], classInfo[2], realCourseName, prof, s[realLoc + 1], s[realLoc + 2], timee, endtime, days);
                    classes.Add(c);
                    foreach (User u in userDB.users)
                    {
                        if (prof == u.getUsername())
                        {
                            u.addClass(c);
                            Console.Out.WriteLine(c);
                        }
                    }
                    place++;
                  
                }
                
                //string x = times.Substring(0, 2);
                //string y = times.Substring(2, 2);
                //Console.WriteLine(x);
                //Console.WriteLine(y);
                //int d = int.Parse(x);
                //int t = int.Parse(y);
                //string days = dayConversion(d);
                //string timee = timeConversion(t);



                ////string numTimes = s[loc + 3]; //Timeblocks

                //Class c = new Class(s[0], realCourseName, s[realLoc], s[realLoc + 1], int.Parse(s[realLoc + 2]), days, timee);

                //classes.Add(c);
            }

        }


        public static string Reverse(string Input)
        {

            // Converting string to character array
            char[] charArray = Input.ToCharArray();

            // Declaring an empty string
            string reversedString = String.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;
        }





        public string dayConversion(int d)
        {
            string days = "";

            if (d / 16 >= 1)
            {
                days = days + "F";
                d = d - 16;
            }
            if (d / 8 >= 1)
            {
                days = days + "R";
                d = d - 8;
            }
            if (d / 4 >= 1)
            {
                days = days + "W";
                d = d - 4;
            }
            if (d / 2 >= 1)
            {
                days = days + "T";
                d = d - 2;
            }
            if (d / 1 >= 1)
            {
                days = days + "M";
                d = d - 1;
            }

            return Reverse(days);
        }

        public string timeConversion(int time)
        {
            time = time / 2;
            string ntime = "";

            if (time < 12)
            {
                ntime = time.ToString() + "AM";
            }

            if (time == 12)
            {
                ntime = time.ToString() + "PM";
            }
            if(time > 12)
            {
                time = time - 12;
                ntime = time.ToString() + "PM";
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
        public void PrintClasses()
        {
            foreach (Class c in classes)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void Calculation()
        {



        }


    }
}




