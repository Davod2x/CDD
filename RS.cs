﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    public class RS
    {
        public UserDB userDB;
        public ClassDB classDB;
        
     

        public RS()
        { 
            this.userDB = new UserDB("UserDB.txt", "CourseHistory.txt");
            this.classDB = new ClassDB("ClassDB.txt", this.userDB);
           // this.CourseHistory = newCourseHistory("CourseHistory.txt")
        }
       
    }
        
        
    
}


    

