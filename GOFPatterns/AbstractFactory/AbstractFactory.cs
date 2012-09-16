using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class AbstractFactory {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

}
