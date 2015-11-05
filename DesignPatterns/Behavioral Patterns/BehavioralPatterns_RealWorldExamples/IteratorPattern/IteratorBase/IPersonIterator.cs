using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern.IteratorBase
{
    public interface IPersonIterator
    {
        void MoveFirst();

        void Reset();

        bool MoveNext();

        Person Current { get; }
    }
}
