using DesignPattern.Creational.Factory.FProduct.FIProduct;

namespace DesignPattern.Creational.Factory.FProduct.FIConcreteProduct
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
