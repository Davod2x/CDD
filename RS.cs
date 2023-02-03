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

        public RS()
        { 
            FileStream userDB = File.Open("UserDB.txt", FileMode.Open);
            FileStream classDB = File.Open("ClassDB.txt", FileMode.Open);
        }
    }
        
        
    
}


    

