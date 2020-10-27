using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Iterators.Abstract;

namespace Iterator.Iterators.Concerete
{
    public class LAPaperIterator : IIterator
    {
        private string[] _reporters;
        private int current;

        public LAPaperIterator(string[] reporters)
        {
            this._reporters = reporters;
            current = 0;
        }
        public string CurrentItem()
        {
            return _reporters[current];
        }

        public void First()
        {
            current = 0;
        }

        public bool IsDone()
        {
            return current >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[current++];
        }
    }
}
