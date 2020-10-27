using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;

namespace AbstractFactory.Entities.Concerete.National
{
    public class NationalLoanAccount:ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Loan to National Account");
        }
    }
}
