using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyB : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
