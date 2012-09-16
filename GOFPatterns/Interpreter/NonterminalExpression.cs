using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter {


    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    class NonterminalExpression : AbstractExpression {
        public override void Interpret(Context context) {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
