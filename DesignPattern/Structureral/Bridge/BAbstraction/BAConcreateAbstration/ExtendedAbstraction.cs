using DesignPattern.Structureral.Bridge.BAbstraction.BAAbstraction;
using DesignPattern.Structureral.Bridge.BImplementation.BIImplementation;

namespace DesignPattern.Structureral.Bridge.BAbstraction.BAConcreateAbstration
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }

    }
}
