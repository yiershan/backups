using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver("X", s));
            s.Attach(new ConcreteObserver("Y", s));
            s.Attach(new ConcreteObserver("Z", s));

            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
