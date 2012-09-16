using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter {

    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Target {
        public virtual void Request() {
            Console.WriteLine("Called Target Request()");
        }
    }
}
