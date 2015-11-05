using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPattern.IteratorBase;

namespace IteratorPattern.AggregateBase
{
    public interface IPersonEnumerable
    {
        IPersonIterator GetIterator();
    }
}
