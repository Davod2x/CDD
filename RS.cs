﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CDD
{
    internal class RS
    {
        public UserDB userDB;
        public ClassDB classDB;
        
     

        public RS()
        { 
            this.userDB = new UserDB("UserDB.txt", "CourseHistory.txt");
            this.classDB = new ClassDB("ClassDB.txt", ref this.userDB, "S23");
            
           // this.CourseHistory = newCourseHistory("CourseHistory.txt")
        }
        public RS(string userDB, string classDB, string courseHistory)
        {
            this.userDB = new UserDB(userDB, courseHistory);
            this.classDB = new ClassDB(classDB, ref this.userDB, "S23");
        }
        public void run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login(this));
        }

    }
        
        
    
}


    

