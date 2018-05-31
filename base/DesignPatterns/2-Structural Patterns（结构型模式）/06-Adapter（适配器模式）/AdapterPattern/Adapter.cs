using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : Adaptee, ITarget {
        public void Request() {
            SpecificRequest();
        }
    }
}
