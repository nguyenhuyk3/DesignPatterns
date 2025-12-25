using DesignPattern.Structureral.Adapter.AAdaptee;
using DesignPattern.Structureral.Adapter.ATarget.AITarget;

namespace DesignPattern.Structureral.Adapter.AAdapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class Adapter1 : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter1(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
