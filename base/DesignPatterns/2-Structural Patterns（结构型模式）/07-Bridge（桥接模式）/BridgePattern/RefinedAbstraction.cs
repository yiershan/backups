using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern {
    public class RefinedAbstraction : Abstraction {
        public override void Operation() {
            implementor.Operation();
        }
    }
}
