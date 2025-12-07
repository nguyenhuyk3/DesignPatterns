

using DesignPattern.Creational.Factory.FCreator.FACreator;
using DesignPattern.Creational.Factory.FProduct.FIConcreteProduct;
using DesignPattern.Creational.Factory.FProduct.FIProduct;

namespace DesignPattern.Creational.Factory.FCreator.FConcreteCreator
{
    public class ConcreteCreator1 : ACreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
