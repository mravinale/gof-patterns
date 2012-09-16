using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod {

    class ConcreteCreatorA : Creator {

        public override Product FactoryMethod() {

            return new ConcreteProductA();

        }

    }
}
