using System;
using FactoryMethod.Factories.Abstract;
using FactoryMethod.Factories.Concerete;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingAcctFactory() as ICreditUnionFactory;

            var citiAcct = factory.GetSavingAccount("CITI-321");
            var nationalAcct = factory.GetSavingAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is {citiAcct.Balance} and national balance is {nationalAcct.Balance}");
            Console.ReadLine();
        }
    }
}
