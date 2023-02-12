using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class Class
    {
        public string name;
        public string prof;
        private int days;
        private float time;
        private float Ntime;

        public Class(float name, float prof, int days, float time, float Ntime)
        {

        }


        public int dayConversion(int days)
        {

            if (days / 16 >= 1)
            {
                Console.Out.WriteLine("Friday");
                days = days - 16;
            }
            if (days / 8 >= 1)
            {
                Console.Out.WriteLine("Thursday");
                days = days - 8;
            }
            if (days / 4 >= 1)
            {
                Console.Out.WriteLine("Wednesday");
                days = days - 4;
            }
            if (days / 2 >= 1)
            {
                Console.Out.WriteLine("Tuesday");
                days = days - 2;
            }
            if (days / 1 >= 1)
            {
                Console.Out.WriteLine("Monday");
                days = days - 1;
            }

            return days;
        }

        public float timeConversion(float time)
        {
            float ntime;
          
            if (time >= 12 )
            {
               
                if (time == 12)
                {
                    ntime = 12;
                }
                else
                {
                    ntime = time - 12;
                }
                Console.Out.WriteLine("PM");
            }

            else
            {
                ntime = time;
                Console.Out.WriteLine("AM");
            }



            return ntime;
        }
        public void lenghtConvo(int len)
        {
            if (len == 2)
            {
                Console.Out.WriteLine("1 hour long");
            }
            if (len == 3)
                Console.Out.WriteLine("1.5 hour long");



        }






    }
}




