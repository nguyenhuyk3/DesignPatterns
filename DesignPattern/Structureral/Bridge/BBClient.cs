using DesignPattern.Structureral.Bridge.BAbstraction.BAAbstraction;
using DesignPattern.Structureral.Bridge.BAbstraction.BAConcreateAbstration;
using DesignPattern.Structureral.Bridge.BClient;
using DesignPattern.Structureral.Bridge.BImplementation.BIConcreteImplementation;
using System;

namespace DesignPattern.Structureral.Bridge
{
    public class BBClient
    {
        public void Main()
        {
            Client client = new Client();

            Abstraction abstraction;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
