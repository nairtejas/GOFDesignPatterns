using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPattern.ConcreteAggregate;
using IteratorPattern.IteratorBase;

namespace IteratorPattern.ConcreteIterator
{
    public class PersonEnumerator:IPersonIterator
    {
        private PersonAggregate _aggregate;
        int _position;

        public PersonEnumerator(PersonAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public void MoveFirst()
        {
            if(_aggregate.Count==0)
            {
                throw new InvalidOperationException();
            }
            _position = 0;
        }

        public void Reset()
        {
            _position = -1;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _aggregate.Count;
        }

        public Person Current
        {
            get
            {
                if (_position < _aggregate.Count)
                    return _aggregate[_position];
                throw new InvalidOperationException();
            }
        }
    }
}
