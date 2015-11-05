using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IteratorPattern.ConcreteAggregate;
using IteratorPattern.IteratorBase;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonAggregate aggregate = new PersonAggregate();
            aggregate.Add(new Person(){FirstName = "Robert", Height = 168,LastName = "Kanasz"});
            aggregate.Add(new Person(){FirstName = "John", Height = 181, LastName = "Doe" });
            aggregate.Add(new Person() { FirstName = "Jane", Height = 158, LastName = "Doe" });

            IPersonIterator iterator = aggregate.GetIterator();

            iterator.Reset();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current.FirstName + " " + iterator.Current.LastName);
            }

        }
    }
}
