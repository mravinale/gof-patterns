using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod {

    class MainApp {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            // An array of creators
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (var creator in creators) {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
