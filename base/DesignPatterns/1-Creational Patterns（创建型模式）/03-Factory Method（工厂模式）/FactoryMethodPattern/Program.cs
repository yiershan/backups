using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories = new Factory[2];

            factories[0] = new ConcreteFactoryA();
            factories[1] = new ConcreteFactoryB();

            foreach (var factory in factories) {
                Product product = factory.CreateProduct();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
    }
}
