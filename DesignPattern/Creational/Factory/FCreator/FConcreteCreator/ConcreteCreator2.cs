using DesignPattern.Creational.Factory.FCreator.FACreator;
using DesignPattern.Creational.Factory.FProduct.FIConcreteProduct;
using DesignPattern.Creational.Factory.FProduct.FIProduct;

namespace DesignPattern.Creational.Factory.FCreator.FConcreteCreator
{
    public class ConcreteCreator2 : ACreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
