using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype {

    /// <summary>
    /// MainApp startup class for Structural
    /// Prototype Design Pattern.
    /// </summary>
    class MainApp {

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {

            // Create two instances and clone each
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }

    }

}
