using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Factories.Abstract;
using AbstractFactory.Factories.Concerete;

namespace AbstractFactory.Factories
{

    // Object Instance Creator Provider
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI"))
            {
                return new CitiCreditUnionFactory();
            }

            else if(accountNo.Contains("NATIONAL"))
            {
                return new NationalCreditUnionFactory();
            }

            else
            {
                return null;
            }
        }
    }

}
