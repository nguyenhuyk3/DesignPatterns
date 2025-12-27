using DesignPattern.Structureral.Bridge.BImplementation.BIImplementation;

namespace DesignPattern.Structureral.Bridge.BImplementation.BIConcreteImplementation
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}
