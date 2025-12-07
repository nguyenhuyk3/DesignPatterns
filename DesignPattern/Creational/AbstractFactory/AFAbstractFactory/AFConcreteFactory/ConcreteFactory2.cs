using DesignPattern.Creational.AbstractFactory.AFAbstractFactory.AFIAbstractFactory;
using DesignPattern.Creational.AbstractFactory.AFProduct.AFConcreteProduct;
using DesignPattern.Creational.AbstractFactory.AFProduct.AFIProduct;

namespace DesignPattern.Creational.AbstractFactory.AFAbstractFactory.AFConcreteFactory
{
    // Each Concrete Factory has a corresponding product variant.
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
