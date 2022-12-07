namespace Logic.Infrastructure
{
    public interface IObserver<T>
    {
        public void OnEventRaised(ISubject<T> head, T args);
    }
}
