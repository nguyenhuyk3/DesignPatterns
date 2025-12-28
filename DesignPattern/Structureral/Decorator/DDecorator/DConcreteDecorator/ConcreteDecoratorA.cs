using DesignPattern.Structureral.Decorator.DComponent.DAComponent;
using DesignPattern.Structureral.Decorator.DDecorator.DADecorator;

namespace DesignPattern.Structureral.Decorator.DDecorator.DConcreteDecorator
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    public class ConcreteDecoratorA : ADecorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
