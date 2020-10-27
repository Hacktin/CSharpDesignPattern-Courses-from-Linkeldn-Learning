using System;
using System.Collections.Generic;
using System.Text;

namespace Decarator.Components.Base
{
    public abstract class Car
    {
        public string Description { get; set; }

        public abstract string GetDescription();

        public abstract double GetPrice();
    }
}
