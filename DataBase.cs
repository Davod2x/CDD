using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace CDD
{
    internal class DataBase
    {
        protected List<string> s = new List<string>();
        private char[] whitespace;
        protected string[] strings;
        public DataBase() { 
            this.strings = new string[] { };
            this.whitespace = new char[] { ' ', '\t' };
        }
        public void readInFile(string filePath, string type)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                foreach (string str in strings)
                {
                    if (str.Length > 0)
                        s.Add(str);
                }
            }
    }
}
