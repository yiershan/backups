using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ConcreteSubject : Subject {
        public override void Request() {
            Console.WriteLine("Called ConcreteSubject.Request()");
        }
    }
}
