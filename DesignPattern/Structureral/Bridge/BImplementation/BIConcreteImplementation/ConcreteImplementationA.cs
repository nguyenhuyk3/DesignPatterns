using DesignPattern.Structureral.Bridge.BImplementation.BIImplementation;

namespace DesignPattern.Structureral.Bridge.BImplementation.BIConcreteImplementation
{

    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
