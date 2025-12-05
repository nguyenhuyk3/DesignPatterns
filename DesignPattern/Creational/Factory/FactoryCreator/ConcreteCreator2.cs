using DesignPattern.Creational.Factory.FactoryProduct;

namespace DesignPattern.Creational.Factory.FactoryCreator
{
    public class ConcreteCreator2 : ACreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
