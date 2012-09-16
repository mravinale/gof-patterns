using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight {

    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>
    class UnsharedConcreteFlyweight : Flyweight {
        public override void Operation(int extrinsicstate) {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
              extrinsicstate);
        }
    }
}
