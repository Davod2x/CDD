using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class User
    {
        private string id;
        private string Name { get; set; }
        private string password;

        public User(string id,string password)
        {
            this.id = id;
 
            this.password = password;
        }
    }
    
}
