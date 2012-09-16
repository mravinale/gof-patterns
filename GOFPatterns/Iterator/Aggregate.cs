using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator {

    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate {
        public abstract Iterator CreateIterator();
    }
}
