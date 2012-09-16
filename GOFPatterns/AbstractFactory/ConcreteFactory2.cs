using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class ConcreteFactory2 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB() {
            return new ProductB2();
        }
    }

}
