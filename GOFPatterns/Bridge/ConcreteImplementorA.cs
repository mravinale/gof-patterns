using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge {

    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    class ConcreteImplementorA : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
