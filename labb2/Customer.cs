using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
    class Customer
    {
        public string Addres { get; set; }
        public int Cellphone { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public List<BankAccount> bankAccounts { get; protected set; } = new List<BankAccount>(); 
        public Customer()
        { bankAccounts = new List<BankAccount>(); }


        public static BankAccount CreateAccount(string accountType)
        {
            BankAccount bankAccount;

            if (accountType.Equals("CheckingAccount"))
            { bankAccount = new CheckingAccount(); }

            else if (accountType.Equals("SavingsAccount"))
            { bankAccount = new SavingsAccount(); }

            else bankAccount = new ReterimentAccount();

            return bankAccount;
        }

       
    }

   


}
