using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder {

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class Builder {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
