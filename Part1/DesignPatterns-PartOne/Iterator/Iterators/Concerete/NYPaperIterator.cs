using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iterator.Iterators.Abstract;

namespace Iterator.Iterators.Concerete
{
    public class NYPaperIterator : IIterator
    {

        private List<string> _reporters;
        private int current;

        public NYPaperIterator(List<string> reporters)
        {
            this._reporters = reporters;
            current = 0;
        }
        public string CurrentItem()
        {
            return _reporters.ElementAt(current);
        }

        public void First()
        {
            current = 0;
        }

        public bool IsDone()
        {
            return current >= _reporters.Count;
        }

        public string Next()
        {
            return _reporters.ElementAt(current++);
        }
    }
}
