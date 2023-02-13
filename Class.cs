using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Class
    {
        private string Name { get; set; }
        private string Dpt { get; set; }
        private string ClassNum { get; set; }
        private string Section { get; set; }
        private string Prof { get; set; }
        private string Credits { get; set; }
        private int Seats { get; set; }
        private int SeatsAvail { get; set; }
        private string TimeBlocks { get; set; }
        private string Days { get; set; }
        private string Time { get; set; }
        private int TimeLen { get; set; }

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
