namespace ObserverPattern.Base
{
    public abstract class Observer
    {
        protected Subject Subject;
        public abstract void Notify(Subject subject, object arg);
    }
}
