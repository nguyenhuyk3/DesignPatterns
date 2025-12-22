using DesignPattern.Behavioral.Mediator.MComponent.MBComponent;
using System;

namespace DesignPattern.Behavioral.Mediator.MComponent.MConcreteComponent
{
    public class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");

            this._mediator.Notify(this, "D");
        }
    }
}
