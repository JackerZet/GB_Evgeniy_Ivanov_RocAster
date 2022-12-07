namespace Logic.Infrastructure
{
    public interface ISubject<T>
    {
        public void AddObserver(IObserver<T> observer);

        public void RemovObserver(IObserver<T> observer);

        public void Notify(T arg);
        
    }
}
