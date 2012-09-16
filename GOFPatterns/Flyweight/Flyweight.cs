using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight {

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Flyweight {
        public abstract void Operation(int extrinsicstate);
    }
}
