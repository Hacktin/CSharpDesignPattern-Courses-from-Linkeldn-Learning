using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;

namespace AbstractFactory.Entities.Concerete.National
{
    public class NationalSavingAccount:ISavingAccount
    {
        public NationalSavingAccount()
        {
            Console.WriteLine("Saving to National Account");
        }
    }
}
