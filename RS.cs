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
        protected ClassDB classDB;
        protected TransactionDB transactionDB;
     

        public RS()
        { 
            this.userDB = new UserDB("UserDB.txt");
            this.classDB = new ClassDB();
        }
       
    }
        
        
    
}


    

