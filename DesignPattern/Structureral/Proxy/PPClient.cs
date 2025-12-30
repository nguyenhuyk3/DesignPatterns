using DesignPattern.Structureral.Proxy.PClient;
using DesignPattern.Structureral.Proxy.PProxy.PConcreteProxy;
using DesignPattern.Structureral.Proxy.PSubject.PConcreteSubject;
using System;

namespace DesignPattern.Structureral.Proxy
{
    public class PPClient
    {
        public void Main()
        {
            
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            CProxy proxy = new CProxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}
