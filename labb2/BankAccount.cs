using System;
using System.Collections.Generic;
using System.Text;

namespace labb2
{


    public class BankAccount
    {
        public string AccountType { get; set; }

        public decimal Balance { get; protected set; }

        public decimal Credit { get; protected set; }


        public decimal Insättning(decimal deposit)
        {
            Balance = Balance + deposit;
            return Balance;
        }

        public decimal SetCredit(decimal kreditamount)
        {
            Credit = kreditamount;
            return Credit;
        }


        public virtual bool Uttaggodkänt(decimal withdrawl)
        { 
            if (Balance >= withdrawl)
            { return true; }
            else
                return false; 
        }

        public decimal Uttag (decimal withdrawl)
        {
            Balance = Balance - withdrawl;
            return Balance;
        }

        
        public virtual decimal TillgängligtSaldo()
        {
            decimal availblebalance = Balance;
              return availblebalance; 
        }

        public override string ToString()
        {
            return $"{AccountType} Saldo: {Balance}KR Tillgänglig Kredit {Credit}";
        }
    }

}
