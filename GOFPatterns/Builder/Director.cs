using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder {

    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Director {
        // Builder uses a complex series of steps
        public void Construct(Builder builder) {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
