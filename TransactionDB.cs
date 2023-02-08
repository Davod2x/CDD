using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDD
{
    internal class TransactionDB
    {
        private string[] actions;
        private int location;

        public TransactionDB()
        {
            string[] lines = new string[25000];
        }

        public void addTransaction(string action)
        {
            actions[location] = action;
        }

        public void findTransaction(string action)
        {
            bool found = false;
            while (found == false)
            {

            }
        }
    }
}
