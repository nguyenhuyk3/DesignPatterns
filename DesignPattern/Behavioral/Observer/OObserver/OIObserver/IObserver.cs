using DesignPattern.Behavioral.Observer.OSubject.OISubject;

namespace DesignPattern.Behavioral.Observer.OObserver.OIObserver
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
