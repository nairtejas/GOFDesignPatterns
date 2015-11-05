using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPattern.AggregateBase;
using IteratorPattern.ConcreteIterator;
using IteratorPattern.IteratorBase;

namespace IteratorPattern.ConcreteAggregate
{
    public class PersonAggregate : IPersonEnumerable
    {
        private List<Person> _persons = new List<Person>();

        public Person this[int index]
        {
            get { return _persons[index]; }
        }

        public IPersonIterator GetIterator()
        {
            return new PersonEnumerator(this);
        }

        public int Count
        {
            get { return _persons.Count; }
        }

        public void Add(Person person)
        {
            _persons.Add(person);
        }
    }
}
