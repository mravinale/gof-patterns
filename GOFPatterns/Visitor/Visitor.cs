using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor {

    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    abstract class Visitor {
        public abstract void VisitConcreteElementA(
          ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
          ConcreteElementB concreteElementB);
    }

}
