using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteFactoryA : Factory {
        public override Product CreateProduct() {
            return new ConcreteProductA();
        }
    }
}
