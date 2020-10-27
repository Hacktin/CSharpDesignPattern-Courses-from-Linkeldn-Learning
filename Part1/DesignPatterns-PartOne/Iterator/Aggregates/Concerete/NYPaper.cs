using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Aggregates.Abstract;
using Iterator.Iterators.Abstract;
using Iterator.Iterators.Concerete;

namespace Iterator.Aggregates.Concerete
{
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;

        public NYPaper()
        {
            _reporters = new List<string>()
            {
                "John Mesh-NY",
                "Susanna Lee-NY",
                "Paul Randy-NY",
                "Kim Fields-NY",
                "Sky Taylor-NY"
            };
        }
        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}
