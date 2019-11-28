using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{


    class BankAccount
    {
        public string AccountType { get; set; }

        public decimal Balance { get; protected set; }


        public List<Customer> customers { get; protected set; } = new List<Customer>();


            public decimal Insättning(decimal deposit)
        {
            Balance = Balance + deposit;
          


            return Balance;
        }


        public virtual bool Uttag(decimal withdrawl)
        { 
            if (Balance >= withdrawl)
            { return true; }
            else
                return false; 
        }

        
        public virtual decimal TillgängligtSaldo()
        {
            decimal availblebalance = Balance;


              return availblebalance; }
    }

}
