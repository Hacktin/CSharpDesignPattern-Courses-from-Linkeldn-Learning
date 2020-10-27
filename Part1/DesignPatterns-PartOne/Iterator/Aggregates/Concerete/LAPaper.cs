using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Aggregates.Abstract;
using Iterator.Iterators.Abstract;
using Iterator.Iterators.Concerete;

namespace Iterator.Aggregates.Concerete
{
    public class LAPaper : INewspaper
    {
        private string[] _reporters;

        public LAPaper()
        {
            _reporters = new[]
            {
                "Ronald Smith-LA",
                "Danny Glover-LA",
                "Yolanda Adams-LA",
                "Jerry Straight-LA",
                "Rhonda Lime-LA"
            };
        }
        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}
