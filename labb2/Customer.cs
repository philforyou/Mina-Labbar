using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
    public class Customer
    {
        public string Addres { get; set; }
        public string Cellphone { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public List<BankAccount> BankAccounts { get; protected set; } = new List<BankAccount>();


        public Customer CreateCustomer(string firstname, string lastname, string cellphone)
        {
            Customer customer = new Customer();
            customer.Firstname = firstname;
            customer.Lastname = lastname;
            customer.Cellphone = cellphone;
            return customer;
        }
        public List<BankAccount> GetBankAccounts()
        {
            return BankAccounts;
        }

        public BankAccount CreateAccount(string accountType)
        {
            BankAccount bankAccount;



            if (accountType.Equals("CheckingAccount"))
            {
                bankAccount = new CheckingAccount();
                 bankAccount.AccountType = "CheckingAccount";
            }

            else if (accountType.Equals("SavingsAccount"))
            {
                bankAccount = new SavingsAccount();
                bankAccount.AccountType = "SavingsAccount";
            }



            else
            {bankAccount = new ReterimentAccount();
                bankAccount.AccountType = "ReterimentAccount";
            }
            

            BankAccounts.Add(bankAccount);
            return bankAccount;

           
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} ";
            
        }

    }
}
       
    

   



