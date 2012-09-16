using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter {

    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    abstract class AbstractExpression {
        public abstract void Interpret(Context context);
    }

}
