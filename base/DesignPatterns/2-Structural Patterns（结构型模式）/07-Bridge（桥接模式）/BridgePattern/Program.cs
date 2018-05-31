using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
}
