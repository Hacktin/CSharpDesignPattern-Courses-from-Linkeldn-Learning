using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Entities.Abstract;

namespace FactoryMethod.Factories.Abstract
{

    // Base Object Instance Creator
    public interface ICreditUnionFactory
    {
        ISavingAccount GetSavingAccount(string acctNo);
    }
}
