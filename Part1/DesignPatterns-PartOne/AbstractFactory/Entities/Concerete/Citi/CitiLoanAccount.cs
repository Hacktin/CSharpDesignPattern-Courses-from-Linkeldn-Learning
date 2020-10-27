using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;

namespace AbstractFactory.Entities.Concerete.Citi
{
    // Concerete Entity
    public class CitiLoanAccount:ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Loan to Citi Account");
        }
    }
}
