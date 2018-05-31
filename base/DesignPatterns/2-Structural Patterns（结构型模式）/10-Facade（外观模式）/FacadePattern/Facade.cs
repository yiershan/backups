using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade {
        private SubSystemOne _subSystemOne;
        private SubSystemTwo _subSystemTwo;
        private SubSystemThree _subSystemThree;
        private SubSystemFour _subSystemFour;

        public Facade() {
            _subSystemOne = new SubSystemOne();
            _subSystemTwo = new SubSystemTwo();
            _subSystemThree = new SubSystemThree();
            _subSystemFour = new SubSystemFour();
        }

        public void MethodA() {
            Console.WriteLine("MethodA() ----");
            _subSystemOne.MethodOne();
            _subSystemTwo.MethodTwo();
            _subSystemFour.MethodFour();
        }

        public void MethodB() {
            Console.WriteLine("MethodB() ----");
            _subSystemTwo.MethodTwo();
            _subSystemThree.MethodThree();
        }
    }
}
