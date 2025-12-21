using DesignPattern.Behavioral.Visitor.VClient;
using DesignPattern.Behavioral.Visitor.VComponent.VConcreteComponent;
using DesignPattern.Behavioral.Visitor.VComponent.VIComponent;
using DesignPattern.Behavioral.Visitor.VVisitor.VConcreteVisitor;
using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Visitor
{
    public class VVClient
    {
        public void Main()
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}
