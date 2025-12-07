using DesignPattern.Creational.AbstractFactory.AFProduct.AFIProduct;

namespace DesignPattern.Creational.AbstractFactory.AFProduct.AFConcreteProduct
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteProductB1 : IAbstractProductB
    {
        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}
