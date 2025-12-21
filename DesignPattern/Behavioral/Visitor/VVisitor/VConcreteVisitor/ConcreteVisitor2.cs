using DesignPattern.Behavioral.Visitor.VComponent.VConcreteComponent;
using DesignPattern.Behavioral.Visitor.VVisitor.VIVisitor;
using System;

namespace DesignPattern.Behavioral.Visitor.VVisitor.VConcreteVisitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
        }
    }
}
