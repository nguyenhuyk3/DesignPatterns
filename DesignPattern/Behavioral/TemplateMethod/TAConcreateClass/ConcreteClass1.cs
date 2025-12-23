using DesignPattern.Behavioral.TemplateMethod.TMAbstractClass;
using System;

namespace DesignPattern.Behavioral.TemplateMethod.TAConcreateClass
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }

        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }
    }
}
