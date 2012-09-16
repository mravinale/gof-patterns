using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod {

    class ConcreteCreatorB : Creator {

        public override Product FactoryMethod() {
        
            return new ConcreteProductB();

        }

    }

}
