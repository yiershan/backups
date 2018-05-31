using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory abstractFatory) {
            _abstractProductA = abstractFatory.CreateProductA();
            _abstractProductB = abstractFatory.CreateProductB();
        }

        public void Run() {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
