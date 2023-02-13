using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class Class
    {
        private string name { get; set; }
        private string dpt { get; set; }
        private string classNum { get; set; }
        private string section { get; set; }
        private string prof { get; set; }
        private float credits { get; set; }
        private int seats { get; set; }
        private int seatsAvail { get; set; }
        private string timeBlocks { get; set; }
        private string days { get; set; }
        private string time { get; set; }
        private int timeLen { get; set; }

        public Class(string dpt, string name,  string prof, float credits, int seats, string timeBlocks, string days)
        {
            this.dpt = dpt;
            this.name = name;
            this.classNum = "";
            this.section = "";
            this.prof = prof;
            this.credits = credits;
            this.seats = seats;
            this.seatsAvail = seats;
            this.timeBlocks = timeBlocks;
            this.days = days;
            this.time = "";
            this.timeLen = 0;
        }
    }

}
