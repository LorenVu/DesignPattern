namespace ObserverPattern.Base
{
    public class Subject
    {
        public Subject() {}

        private readonly List<Observer> Observables = new List<Observer> ();

        public void AttachObserver(Observer observer)
        {
            Observables.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            Observables.Remove(observer);
        }

        public void NotifyObserver(Subject subject, object arg)
        {
            Observables.ForEach(observer => observer.Notify(subject, arg));
        }
    }
}
