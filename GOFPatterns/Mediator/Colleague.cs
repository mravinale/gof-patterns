using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator {

    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    abstract class Colleague {
        protected Mediator mediator;

        // Constructor
        public Colleague(Mediator mediator) {
            this.mediator = mediator;
        }
    }
}
