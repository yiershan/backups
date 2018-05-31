using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ConcreteFactory2 : AbstractFactory {
        public override AbstractProductA CreateProductA() {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB() {
            return new ProductB2();
        }
    }
}
