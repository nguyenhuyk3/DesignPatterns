using DesignPattern.Behavioral.Mediator.MComponent.MConcreteComponent;
using DesignPattern.Behavioral.Mediator.MMediator.MConcreteMediator;
using System;

namespace DesignPattern.Behavioral.Mediator
{
    public class MClient
    {
        public void Main()
        {
            // The client code.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
