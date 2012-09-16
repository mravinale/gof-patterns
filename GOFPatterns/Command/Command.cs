using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command {

    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class Command {
        protected Receiver receiver;

        // Constructor
        public Command(Receiver receiver) {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
