

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Bank
{
    /// <summary>
    /// This class defines the account for a bank.
    /// This is the blueprint
    /// </summary>
    class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        #endregion

        
        
        
        #region Properties
        public int AccountNumber { get; private set; }

        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }
        #endregion

        #region Methods
        
        //constructors
       
        public Account() : this("", 0.0M)
        {
            //lastAccountNumber = lastAccountNumber + 1;
            //thisAccountNumber = lastAccountNumber += 1;
            //this.AccountNumber = ++lastAccountNumber;
        }

        public Account(string emailAddress) : this(emailAddress, 0.0M)
        {
            //this.AccountNumber = ++lastAccountNumber;
            //this.EmailAddress = emailAddress;
        }

        public Account(string emailAddress, decimal balance)
        {
            this.AccountNumber = ++lastAccountNumber;
            this.EmailAddress = emailAddress;
            this.Balance = balance;
        }

        // methods that are not constructors
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}

