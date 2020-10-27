using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Entities.Abstract;

namespace FactoryMethod.Entities.Concerete
{

    // Concerete Entity
    public class NationalSavingAccount:ISavingAccount
    {
        public NationalSavingAccount()
        {
            Balance = 2000;
        }
    }
}
