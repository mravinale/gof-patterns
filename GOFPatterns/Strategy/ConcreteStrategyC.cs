using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy {

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ConcreteStrategyC : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine(
              "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

}
