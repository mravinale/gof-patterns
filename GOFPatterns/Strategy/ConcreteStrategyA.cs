using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy {


    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyA : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine(
              "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

}
