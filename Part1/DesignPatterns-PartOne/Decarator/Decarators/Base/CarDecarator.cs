using System;
using System.Collections.Generic;
using System.Text;
using Decarator.Components.Base;

namespace Decarator.Decarators.Base
{
    public class CarDecarator:Car
    {
        protected Car _car;

        public CarDecarator(Car car)
        {
            this._car = car;
        }

        public override string GetDescription() => _car.GetDescription();
        public override double GetPrice() => _car.GetPrice();
    }
}
