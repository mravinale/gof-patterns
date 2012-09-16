using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator {
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    class ConcreteDecoratorB : Decorator {
        public override void Operation() {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior() {
        }
    }
}
