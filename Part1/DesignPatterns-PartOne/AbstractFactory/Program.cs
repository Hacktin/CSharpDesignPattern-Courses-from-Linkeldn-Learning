using System;
using System.Collections.Generic;
using AbstractFactory.Entities.Abstract;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Abstract;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string>()
            {
                "CITI-456",
                "NATIONAL-987",
                "CHASE-222"
            };

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                ICreditUnionFactory creditUnionFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNumbers[i]);

                if (creditUnionFactory == null)
                {
                    Console.WriteLine("Sorry. This credit union w/ account number {0} is invalid",accountNumbers[i]);
                }

                else
                {
                    ILoanAccount loanAccount = creditUnionFactory.GetLoanAccount();
                    ISavingAccount savingAccount = creditUnionFactory.GetSavingAccount();
                }
            }

            Console.ReadLine();
        }
    }
}
