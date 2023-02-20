using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class CourseHistory
    {
        internal class CourseHistoryy
        {
            public List<Class> classes;
            private char[] whitespace;
            private string[] lines;
            private string[] strings;



            public void CourseHistory(string fname, UserDB userDB)
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
                }

            }
        }
    }
}
