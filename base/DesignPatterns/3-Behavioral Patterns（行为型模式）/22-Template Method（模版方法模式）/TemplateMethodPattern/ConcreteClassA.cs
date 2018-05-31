using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ConcreteClassA : AbstractClass {
        public override void PrimitiveOperationOne() {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }

        public override void PrimitiveOperationTwo() {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }
}
