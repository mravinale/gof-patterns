using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter {

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class Adaptee {
        public void SpecificRequest() {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
