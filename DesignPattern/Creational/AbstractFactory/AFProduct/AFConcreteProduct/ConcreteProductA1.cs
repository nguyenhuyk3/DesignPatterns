using DesignPattern.Creational.AbstractFactory.AFProduct.AFIProduct;

namespace DesignPattern.Creational.AbstractFactory.AFProduct.AFConcreteProduct
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
