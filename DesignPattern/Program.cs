using DesignPattern.Creational.Factory;
using DesignPattern.Creational.Singleton;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new SingletonClient().Main();
            //new FactoryClient().Main();
        }
    }
}
