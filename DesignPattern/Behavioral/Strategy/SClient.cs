using DesignPattern.Behavioral.Strategy.SContext;
using DesignPattern.Behavioral.Strategy.SStrategy.SConcreteStrategy;
using System;

namespace DesignPattern.Behavioral.Strategy
{
    public class SClient
    {
        public void Main()
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
