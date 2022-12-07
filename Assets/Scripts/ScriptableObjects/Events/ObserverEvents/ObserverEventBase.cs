using Logic.Infrastructure;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Events
{
    public class ObserverEventBase<T> : ScriptableObject, ISubject<T>
    {
        private readonly List<IObserver<T>> _observers = new();

        public void AddObserver(IObserver<T> observer)
        {
            if (!_observers.Contains(observer)) 
                _observers.Add(observer);
        }

        public void RemovObserver(IObserver<T> observer)
        {
            if (_observers.Contains(observer)) 
                _observers.Remove(observer);
        }

        public void Notify(T args)
        {
            for(int i = 0; i < _observers.Count; i++)           
                _observers[i].OnEventRaised(this, args);
        }
    }
}
