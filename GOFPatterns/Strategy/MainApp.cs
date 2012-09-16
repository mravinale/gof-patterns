using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy {

    /// <summary>
    /// MainApp startup class for Structural
    /// Strategy Design Pattern.
    /// </summary>
    class MainApp {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            Context context;

            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }
    }
}
