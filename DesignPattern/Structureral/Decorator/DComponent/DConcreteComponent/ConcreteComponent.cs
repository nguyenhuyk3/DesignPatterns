using DesignPattern.Structureral.Decorator.DComponent.DAComponent;

namespace DesignPattern.Structureral.Decorator.DComponent.DConcreteComponent
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
