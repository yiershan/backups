using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Receiver
    {
        public void Action() {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
