using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject {
        public ConcreteSubject() {
        }

        public string SubjectState { get; set; }
    }
}
