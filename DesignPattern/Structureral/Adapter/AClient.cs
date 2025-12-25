using DesignPattern.Structureral.Adapter.AAdaptee;
using DesignPattern.Structureral.Adapter.AAdapter;
using DesignPattern.Structureral.Adapter.ATarget.AITarget;
using System;

namespace DesignPattern.Structureral.Adapter
{
    public class AClient
    {
        public void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter1(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
