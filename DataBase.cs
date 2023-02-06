using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class DataBase
    {
        private FileStream file;
        string[] lines;
        public DataBase(string fname)
        {
            this.lines = File.ReadAllLines(fname);
            foreach (string line in lines) { 
            
               
            
            };

        }
    }
}
