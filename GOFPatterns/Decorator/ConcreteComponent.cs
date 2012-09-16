using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator {

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class ConcreteComponent : Component {
        public override void Operation() {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
