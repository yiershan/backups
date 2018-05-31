using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ConcreteClassB : AbstractClass {
        public override void PrimitiveOperationOne() {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }

        public override void PrimitiveOperationTwo() {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}
