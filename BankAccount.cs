using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_lv6
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public string toString()
        {
            return "owner name:" + this.ownerName + "\nowner adress:" + this.ownerAddress + "\nbalance:" + this.balance;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }
        public BankMemento StoreState()
        {
            return new BankMemento(this.ownerName, this.ownerAddress, this.balance);
        }
        public void RestoreState(BankMemento previous)
        {
            this.ownerName = previous.ownerName;
            this.ownerAddress = previous.ownerAddress;
            this.balance = previous.balance;
        }
    }
}
