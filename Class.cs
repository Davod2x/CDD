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
        public string Seats { get; private set; }
        public string SeatsAvail { get; private set; }
        public string TimeBlocks { get; private set; }
        public string Days { get; private set; }
        public string EndTime { get; private set; }
        public string StartTime { get; private set; }

        public string Course { get; private set; }

        public string FormattedTime { get; private set; }



        public Class(string dpt, string classNum, string section, string name,  string prof, string credits, string seats, string startTime, string endTime, string days)
        {
            this.Dpt = dpt;
            this.Name = name;
            this.ClassNum = classNum;
            this.Section = section;
            this.Prof = prof;
            this.Credits = credits;
            this.Seats = seats;
            this.SeatsAvail = seats;
            this.StartTime = startTime;
            this.Days = days;
            this.EndTime = endTime;
            
            Course = Dpt + "-"+ classNum+ "-"+ section;
            FormattedTime = StartTime+ "-" + EndTime;
        }

        //(string name,


        public override string ToString()
        {
            return this.Course + " " + this.Name + " " + this.Prof + " " + this.Credits + " " + this.Seats + " " + this.Days + " " + this.FormattedTime ;
        }
    }

}
