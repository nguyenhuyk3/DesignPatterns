using DesignPattern.Creational.Factory.Product;

namespace DesignPattern.Creational.Factory.Creator
{
    public class ConcreteCreator2 : ACreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
