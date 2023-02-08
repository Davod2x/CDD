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
        private ClassDB classDB;
        private TransactionDB transactionDB;
     

        public RS()
        { 
            userDB = new UserDB("UserDB.txt");
            classDB = new ClassDB();
        }
    }
        
        
    
}


    

