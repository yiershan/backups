using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyA : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
