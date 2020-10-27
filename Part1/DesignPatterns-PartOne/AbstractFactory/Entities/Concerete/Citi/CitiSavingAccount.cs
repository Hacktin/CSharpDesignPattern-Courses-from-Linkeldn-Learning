using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;

namespace AbstractFactory.Entities.Concerete.Citi
{

    // Concerete Entity
   public class CitiSavingAccount:ISavingAccount
    {
        public CitiSavingAccount()
        {
            Console.WriteLine("Saving to Citi Account");
        }
    }
}
