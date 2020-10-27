using System;
using System.Collections.Generic;
using System.Text;
using Decarator.Components.Base;
using Decarator.Decarators.Base;

namespace Decarator.Decarators.Concerete
{
    public class Navigation:CarDecarator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override string GetDescription() => $"{_car.GetDescription()},{Description}";

        public override double GetPrice() => _car.GetPrice() + 5000;
    }
}
