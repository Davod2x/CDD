using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Class
    {
        public string Name { get; private set; }
        public string Dpt { get; private set; }
        public string ClassNum { get; private set; }
        public string Section { get; private set; }
        public string Prof { get; private set; }
        public string Credits { get; private set; }
        public int Seats { get; private set; }
        public int SeatsAvail { get; private set; }
        public string TimeBlocks { get; private set; }
        public string Days { get; private set; }
        public string Time { get; private set; }
        public int TimeLen { get; private set; }

        public Class(string dpt, string name,  string prof, string credits, int seats, string timeBlocks, string days)
        {
            this.Dpt = dpt;
            this.Name = name;
            this.ClassNum = "";
            this.Section = "";
            this.Prof = prof;
            this.Credits = credits;
            this.Seats = seats;
            this.SeatsAvail = seats;
            this.TimeBlocks = timeBlocks;
            this.Days = days;
            this.Time = "";
            this.TimeLen = 0;
        }

        public override string ToString()
        {
            return this.Dpt + " " + this.Name + " " + this.Prof + " " + this.Credits + " " + this.Seats + " " + this.TimeBlocks + " " + this.Days;
        }
    }

}
