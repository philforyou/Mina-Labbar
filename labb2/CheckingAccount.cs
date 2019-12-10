using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
   public class CheckingAccount: BankAccount
    {


        public override decimal TillgängligtSaldo()
        {
            decimal availblebalance = Balance + Credit;
            return availblebalance;
        }
    }

}


