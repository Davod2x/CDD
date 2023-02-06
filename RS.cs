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
        private UserDB userDB;
        private ClassDB usserDB;
        private TransactionDB transactionDB;
        private FileStream classDB;

        public RS()
        { 
            userDB = new UserDB("UserDB.txt");
            classDB = File.Open("ClassDB.txt", FileMode.Open);
        }
    }
        
        
    
}


    

