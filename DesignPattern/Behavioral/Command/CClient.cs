using DesignPattern.Behavioral.Command.CCommand.CConcreteCommand;
using DesignPattern.Behavioral.Command.CInvoker;
using DesignPattern.Behavioral.Command.CReceiver;

namespace DesignPattern.Behavioral.Command
{
    public class CClient
    {
        public void Main()
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
