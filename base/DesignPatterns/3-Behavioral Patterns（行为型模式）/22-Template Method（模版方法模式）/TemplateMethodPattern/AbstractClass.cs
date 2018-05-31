using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperationOne();
        public abstract void PrimitiveOperationTwo();

        public void TemplateMethod() {
            PrimitiveOperationOne();
            PrimitiveOperationTwo();
            Console.WriteLine("");
        }
    }
}
