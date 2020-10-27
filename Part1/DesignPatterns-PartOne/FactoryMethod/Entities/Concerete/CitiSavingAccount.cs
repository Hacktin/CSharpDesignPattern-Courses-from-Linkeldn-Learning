using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Entities.Abstract;

namespace FactoryMethod.Entities.Concerete
{

    // Concerete Entity
    public class CitiSavingAccount:ISavingAccount
    {
        public CitiSavingAccount()
        {
            Balance = 5000;
        }
    }
}
