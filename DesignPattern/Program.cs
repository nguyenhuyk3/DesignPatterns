using DesignPattern.Creational.Builder;
using DesignPattern.Creational.Factory;
using DesignPattern.Creational.Singleton;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //new SingletonClient().Main();
            new FactoryClient().Main();
            //new BuilderClient().Main();
        }
    }
}
