using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class ConcreteFactory1 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB() {
            return new ProductB1();
        }
    }
}
