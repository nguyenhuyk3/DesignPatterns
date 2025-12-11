using DesignPattern.Behavioral.Observer.OObserver.OIObserver;
using DesignPattern.Behavioral.Observer.OSubject.OConcreteSubject;
using DesignPattern.Behavioral.Observer.OSubject.OISubject;
using System;

// Concrete Observers react to the updates issued by the Subject they had
// been attached to.
namespace DesignPattern.Behavioral.Observer.OObserver.OConcreteObserver
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
