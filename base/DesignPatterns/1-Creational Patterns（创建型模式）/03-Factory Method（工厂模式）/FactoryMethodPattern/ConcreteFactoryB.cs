using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteFactoryB : Factory {
        public override Product CreateProduct() {
            return new ConcreteProductB();
        }
    }
}
