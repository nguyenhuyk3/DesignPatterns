using DesignPattern.Behavioral.Visitor.VVisitor.VIVisitor;

namespace DesignPattern.Behavioral.Visitor.VComponent.VIComponent
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
