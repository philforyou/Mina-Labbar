using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{
    class ReterimentAccount : BankAccount
    {


        public override bool Uttag(decimal withdrawl)
        {

            if ((Balance) >= withdrawl * 1.1M)
            { return true; }
            else
                return false;
        }
    }

}
