using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Decarator.Components.Base;
using Decarator.Decarators.Base;

namespace Decarator.Decarators.Concerete
{
    public class LeatherSeats:CarDecarator
    {
        public LeatherSeats(Car car):base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetDescription() => $"{_car.GetDescription()},{Description}";

        public override double GetPrice() => _car.GetPrice() + 2500;
    }
}
