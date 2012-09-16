using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    class Client {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor
        public Client(AbstractFactory factory) {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run() {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
