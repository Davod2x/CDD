using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class TransactionDB
    {
        private string[] actions;
        private int location;
        public List<Class> classes;
        private char[] whitespace;
        private string[] lines;
        private string[] strings;

        public TransactionDB(string fname, UserDB userDB)
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

            int realLoc = 1;              int place = realLoc + 4;
            while (place < s.Count)
            {
                Class c = new Class(s[0], s[1], s[2], s[3], s[4], s[5]);
                classes.Add(c);
            }
        }
    }
    
}  