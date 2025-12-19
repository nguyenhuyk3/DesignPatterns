using DesignPattern.Behavioral.Command.CCommand.CICommand;
using System;

namespace DesignPattern.Behavioral.Command.CCommand.CConcreteCommand
{
    public class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}
