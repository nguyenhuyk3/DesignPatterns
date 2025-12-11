using DesignPattern.Behavioral.Observer.OObserver.OConcreteObserver;
using DesignPattern.Behavioral.Observer.OSubject.OConcreteSubject;

namespace DesignPattern.Behavioral.Observer
{
    public class OClient
    {
        public void Main()
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
