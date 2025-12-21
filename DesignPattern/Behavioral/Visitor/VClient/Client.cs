using DesignPattern.Behavioral.Visitor.VComponent.VIComponent;
using DesignPattern.Behavioral.Visitor.VVisitor.VIVisitor;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Visitor.VClient
{
    public class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
