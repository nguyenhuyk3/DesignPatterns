using DesignPattern.Structureral.Decorator.DComponent.DAComponent;
using DesignPattern.Structureral.Decorator.DDecorator.DADecorator;

namespace DesignPattern.Structureral.Decorator.DDecorator.DConcreteDecorator
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    public class ConcreteDecoratorB : ADecorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
