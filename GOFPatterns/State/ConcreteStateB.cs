using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State {


    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    class ConcreteStateB : State {
        public override void Handle(Context context) {
            context.State = new ConcreteStateA();
        }
    }

}
