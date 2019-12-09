using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
   public class CheckingAccount: BankAccount
    {

        public override bool Uttaggodkänt(decimal withdrawl)
        {
            if (Balance + Credit >= withdrawl)
            { return true; }
            else
                return false;
        }

        public override decimal TillgängligtSaldo()
        {
            decimal availblebalance = Balance + Credit;
            return availblebalance;
        }
    }

}


