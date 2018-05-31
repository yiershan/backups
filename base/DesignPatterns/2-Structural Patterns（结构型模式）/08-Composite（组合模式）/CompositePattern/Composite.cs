using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Composite : Component {

        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) {

        }

        public override void Add(Component c) {
            _children.Add(c);
        }

        public override void Display(int depth) {
            Console.WriteLine(new String('-', depth) + _name);

            foreach (var component in _children) {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component c) {
            _children.Remove(c);
        }
    }
}
