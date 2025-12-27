using DesignPattern.Structureral.Composite.CClient;
using DesignPattern.Structureral.Composite.CComponent.CConcreteComponent;
using System;

namespace DesignPattern.Structureral.Composite
{
    public class CCClient
    {
        public void Main()
        {
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            ConcreteComposite tree = new ConcreteComposite();
            ConcreteComposite branch1 = new ConcreteComposite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            ConcreteComposite branch2 = new ConcreteComposite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
