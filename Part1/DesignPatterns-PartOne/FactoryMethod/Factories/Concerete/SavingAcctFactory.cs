using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Entities.Abstract;
using FactoryMethod.Entities.Concerete;
using FactoryMethod.Factories.Abstract;

namespace FactoryMethod.Factories.Concerete
{

    // Concerete Object Instance Creator
    public class SavingAcctFactory : ICreditUnionFactory
    {
        public ISavingAccount GetSavingAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingAccount();
            }

            else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingAccount();
            }

            else
            {
                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
