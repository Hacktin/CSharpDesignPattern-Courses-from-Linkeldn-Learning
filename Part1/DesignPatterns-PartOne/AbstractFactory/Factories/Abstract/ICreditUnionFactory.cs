using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Entities.Abstract;

namespace AbstractFactory.Factories.Abstract
{

    // Base Object  Instance Creators
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingAccount GetSavingAccount();

        public abstract ILoanAccount GetLoanAccount();
    }
}
