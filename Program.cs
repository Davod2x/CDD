using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RS rs = new RS();
            rs.run();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login());
            //UserDB udb = new UserDB("UserDB.txt", "CourseHistory.txt");

            //ClassDB db = new ClassDB("ClassDB.txt", udb);




        }
    }
    }
