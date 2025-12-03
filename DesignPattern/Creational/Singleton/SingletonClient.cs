namespace DesignPattern.Creational.Singleton
{
    public class SingletonClient
    {
        public void Main()
        {
            // The client code.
            var s1 = SingletonService.GetInstance();
            var s2 = SingletonService.GetInstance();

            if (s1 == s2)
            {
                System.Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                System.Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
