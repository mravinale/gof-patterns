using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento {

    /// <summary>
    /// MainApp startup class for Structural
    /// Memento Design Pattern.
    /// </summary>
    class MainApp {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main() {
            Originator o = new Originator();
            o.State = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }
}
