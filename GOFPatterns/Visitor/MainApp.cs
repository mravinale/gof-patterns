﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor {

    /// <summary>
    /// MainApp startup class for Structural
    /// Visitor Design Pattern.
    /// </summary>
    class MainApp {
        static void Main() {
            // Setup structure
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            // Create visitor objects
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);

            // Wait for user
            Console.ReadKey();
        }
    }
}
