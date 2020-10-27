using System;
using Iterator.Aggregates.Abstract;
using Iterator.Aggregates.Concerete;
using Iterator.Iterators.Abstract;
using Iterator.Iterators.Concerete;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper ny=new NYPaper();
            INewspaper la=new LAPaper();
            //Aggregates for create to different optional iterators



            IIterator nyIterator = ny.CreateIterator();
            IIterator laIterator = la.CreateIterator();
            // Iterators

            Console.WriteLine("----- LAPaper");
            PrintReporters(laIterator);


            Console.WriteLine("----- NYPaper");
            PrintReporters(nyIterator);

        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
