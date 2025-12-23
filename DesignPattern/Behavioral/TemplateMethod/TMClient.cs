using DesignPattern.Behavioral.TemplateMethod.TAConcreateClass;
using DesignPattern.Behavioral.TemplateMethod.TMClent;
using System;

namespace DesignPattern.Behavioral.TemplateMethod
{
    public class TMClient
    {
        public void Main()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}
