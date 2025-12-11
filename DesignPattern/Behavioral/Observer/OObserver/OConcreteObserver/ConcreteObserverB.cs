using DesignPattern.Behavioral.Observer.OObserver.OIObserver;
using DesignPattern.Behavioral.Observer.OSubject.OConcreteSubject;
using DesignPattern.Behavioral.Observer.OSubject.OISubject;
using System;

namespace DesignPattern.Behavioral.Observer.OObserver.OConcreteObserver
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
