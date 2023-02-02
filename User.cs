using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class User
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }

        public User(string id,string password)
        {
            Id = id;
 
            Password = password;
        }
    }
    
}
