using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge {

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class RefinedAbstraction : Abstraction {
        public override void Operation() {
            implementor.Operation();
        }
    }
}
