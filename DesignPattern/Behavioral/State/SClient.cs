using DesignPattern.Behavioral.State.SContext;
using DesignPattern.Behavioral.State.SState.SConcreteState;

namespace DesignPattern.Behavioral.State
{
    public class SClient
    {
        public void Main() {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}
