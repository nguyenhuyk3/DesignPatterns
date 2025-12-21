using DesignPattern.Behavioral.Visitor.VComponent.VIComponent;
using DesignPattern.Behavioral.Visitor.VVisitor.VIVisitor;

namespace DesignPattern.Behavioral.Visitor.VComponent.VConcreteComponent
{
    public class ConcreteComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}
