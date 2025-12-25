using DesignPattern.Behavioral.ChainOfResponsibility.CAHandler;
using DesignPattern.Behavioral.ChainOfResponsibility.CClientCode;
using DesignPattern.Behavioral.ChainOfResponsibility.CConcreteHandler;
using DesignPattern.Behavioral.Visitor.VClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    public class CClient
    {
        public void Main()
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            ClientCode.Client(monkey);
            Console.WriteLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            ClientCode.Client(squirrel);
        }
    }
}
