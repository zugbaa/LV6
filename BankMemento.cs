using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_lv6
{
    class BankMemento
    {
        public string ownerName;
        public string ownerAddress;
        public decimal balance;
        public BankMemento(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }


    }
}
