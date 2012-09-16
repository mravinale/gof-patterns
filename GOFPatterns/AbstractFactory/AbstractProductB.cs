using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class AbstractProductB {
        public abstract void Interact(AbstractProductA a);
    }

}
