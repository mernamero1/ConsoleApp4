using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vodafone
{
    internal class Savingaccount : Account
    {
        public decimal intsrates { get; private set; }
        public Savingaccount(string id, string number, string name,
            string password = "0000", decimal balance = 0,
            bool status = true, decimal intsrates = 0.0m)
            : base(id, number, name, password, balance, status)
        {
            this.intsrates = intsrates;
        }

    }
        
}
