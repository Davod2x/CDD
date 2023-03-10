using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDD
{
    internal class RS
    {
        public UserDB userDB;
        public ClassDB classDB;
        
     

        public RS()
        { 
            this.userDB = new UserDB("UserDB.txt", "CourseHistory.txt");
            this.classDB = new ClassDB("ClassDB.txt", this.userDB, "S23");
           // this.CourseHistory = newCourseHistory("CourseHistory.txt")
        }
       
    }
        
        
    
}


    

