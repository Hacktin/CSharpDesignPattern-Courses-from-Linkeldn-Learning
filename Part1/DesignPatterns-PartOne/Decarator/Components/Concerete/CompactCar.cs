using System;
using System.Collections.Generic;
using System.Text;
using Decarator.Components.Base;

namespace Decarator.Components.Concerete
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override string GetDescription() => Description;
        public override double GetPrice() => 10000.00;
    }
}
