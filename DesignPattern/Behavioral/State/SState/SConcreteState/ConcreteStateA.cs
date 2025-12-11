using DesignPattern.Behavioral.State.SState.SAState;
using System;

namespace DesignPattern.Behavioral.State.SState.SConcreteState
{
    public class ConcreteStateA : AState
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}
