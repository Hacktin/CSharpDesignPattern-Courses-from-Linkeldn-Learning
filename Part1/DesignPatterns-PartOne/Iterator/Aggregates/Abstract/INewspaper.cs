using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Iterators.Abstract;

namespace Iterator.Aggregates.Abstract
{
   public interface INewspaper
   {
       IIterator CreateIterator();
   }
}
