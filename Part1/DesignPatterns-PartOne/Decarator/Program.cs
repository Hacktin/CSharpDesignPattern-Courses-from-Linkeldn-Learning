using System;
using Decarator.Components.Base;
using Decarator.Components.Concerete;
using Decarator.Decarators.Concerete;

namespace Decarator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car thecar = new CompactCar();

            thecar=new Navigation(thecar);
            thecar=new LeatherSeats(thecar);
            thecar=new Sunroof(thecar);

            Console.WriteLine(thecar.GetDescription());
            Console.WriteLine(thecar.GetPrice());


        }
    }
}
