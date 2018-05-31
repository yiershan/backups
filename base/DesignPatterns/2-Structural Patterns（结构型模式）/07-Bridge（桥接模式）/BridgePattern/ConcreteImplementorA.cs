using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class ConcreteImplementorA : Implementor {
        public override void Operation() {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
