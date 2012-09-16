using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Interpreter {

    /// <summary>
    /// MainApp startup class for Structural
    /// Interpreter Design Pattern.
    /// </summary>
    class MainApp {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            Context context = new Context();

            // Usually a tree
            ArrayList list = new ArrayList();

            // Populate 'abstract syntax tree'
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list) {
                exp.Interpret(context);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
