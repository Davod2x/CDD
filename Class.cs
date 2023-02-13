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
        private int dpt { get; set; }
        private string classNum { get; set; }
        private string section { get; set; }
        private float credits { get; set; }
        private int seats { get; set; }
        private int seatsAvail { get; set; }
        private string days { get; set; }
        private string time { get; set; }
        private int timeLen { get; set; }

        public Class(string name, int dpt, string classNum, string section, float credits, int seats, int seatsAvail, string days, string time, int timeLen)
        {
            this.name = name;
            this.dpt = dpt;
            this.classNum = classNum;
            this.section = section;
            this.credits = credits;
            this.seats = seats;
            this.seatsAvail = seatsAvail;
            this.days = days;
            this.time = time;
            this.timeLen = timeLen;
        }
    }

}
