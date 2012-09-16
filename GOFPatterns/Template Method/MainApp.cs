using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template_Method {

    /// <summary>
    /// MainApp startup class for Real-World
    /// Template Design Pattern.
    /// </summary>
    class MainApp {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();

            // Wait for user
            Console.ReadKey();
        }
    }

}
