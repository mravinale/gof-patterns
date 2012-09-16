using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator {

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    class ConcreteDecoratorA : Decorator {
        public override void Operation() {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
