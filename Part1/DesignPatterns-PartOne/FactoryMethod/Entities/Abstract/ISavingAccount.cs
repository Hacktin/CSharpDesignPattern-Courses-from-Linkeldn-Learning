using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Entities.Abstract
{
    // Base Entity
    public abstract class ISavingAccount
    {
        public decimal Balance { get; set; }
    }
}
