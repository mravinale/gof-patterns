using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade {

    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    class MainApp {

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main() {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
