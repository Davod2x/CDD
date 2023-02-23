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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //UserDB udb = new UserDB("UserDB.txt");
            //ClassDB db = new ClassDB("ClassDB.txt", udb);
            //User user = udb.GetUser("JBiden");
            //user.addClass(db.classes[0]);
            //user.addClass(db.classes[1]);
            //user.addClass(db.classes[2]);


        }
    }
    }
