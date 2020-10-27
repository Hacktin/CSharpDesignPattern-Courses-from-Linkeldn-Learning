using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;
using AbstractFactory.Entities.Concerete.National;
using AbstractFactory.Factories.Abstract;

namespace AbstractFactory.Factories.Concerete
{
    // Concerete Object Instance Creators
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount GetLoanAccount()
        {
            return new NationalLoanAccount();
        }

        public override ISavingAccount GetSavingAccount()
        {
            return new NationalSavingAccount();
        }
    }
}
