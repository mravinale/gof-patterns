using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State {

    /// <summary>
    /// MainApp startup class for Structural
    /// State Design Pattern.
    /// </summary>
    class MainApp {

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
