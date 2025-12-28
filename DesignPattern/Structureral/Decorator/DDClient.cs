using DesignPattern.Structureral.Decorator.DClient;
using DesignPattern.Structureral.Decorator.DComponent.DConcreteComponent;
using DesignPattern.Structureral.Decorator.DDecorator.DConcreteDecorator;
using System;

namespace DesignPattern.Structureral.Decorator
{
    public class DDClient
    {
        public void Main()
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }
}
