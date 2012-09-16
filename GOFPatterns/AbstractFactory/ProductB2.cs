using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory {

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class ProductB2 : AbstractProductB {
        public override void Interact(AbstractProductA a) {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
