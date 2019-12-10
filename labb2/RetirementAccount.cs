using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
    public class ReterimentAccount : BankAccount
    {



        public override bool Uttaggodkänt(decimal withdrawl)
        {
            if (Balance + Credit >= withdrawl*1.1M)
            {
                Uttag(withdrawl);
                return true;
            }
            else
                return false;
        }

        public override decimal Uttag(decimal withdrawl)
        {
            Balance = Balance - (withdrawl * 1.1M);
            return Balance;
        }

    }


}
