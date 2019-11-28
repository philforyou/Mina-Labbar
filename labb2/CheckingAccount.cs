using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
    class CheckingAccount: BankAccount
    {

        
        public decimal Credit { get; protected set; } 

        public override bool Uttag(decimal withdrawl)
        {
            if (Balance + Credit >= withdrawl)
            { return true; }
            else
                return false;
        }
      
        public decimal SetCredit(decimal precentage)
        {
           Credit = precentage * Balance;

              return Credit; }

        public override decimal TillgängligtSaldo()
        {
            decimal availblebalance = Balance + Credit;

            return availblebalance;
        }
    }

}


