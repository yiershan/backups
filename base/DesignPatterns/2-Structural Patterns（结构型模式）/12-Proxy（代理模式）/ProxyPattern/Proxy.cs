using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : Subject {

        private ConcreteSubject _concreteSubject;

        public override void Request() {
            if (_concreteSubject == null) {
                _concreteSubject = new ConcreteSubject();
            }

            _concreteSubject.Request();
        }
    }
}
