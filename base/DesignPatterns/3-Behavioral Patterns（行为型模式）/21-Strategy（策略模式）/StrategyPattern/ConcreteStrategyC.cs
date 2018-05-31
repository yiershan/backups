using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyC : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
