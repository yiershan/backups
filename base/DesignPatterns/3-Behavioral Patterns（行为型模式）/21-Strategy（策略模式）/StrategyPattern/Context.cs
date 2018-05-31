using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy) {
            _strategy = strategy;
        }

        public void ContextInterface() {
            _strategy.AlgorithmInterface();
        }
    }
}
