using System;
using System.Collections.Generic;
using System.Text;
using Decarator.Components.Base;

namespace Decarator.Components.Concerete
{
    public class FullSizeCar:Car
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }

        public override string GetDescription() => Description;
        public override double GetPrice() => 30000.00;
    }
}
