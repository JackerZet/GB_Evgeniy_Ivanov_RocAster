using System;

namespace Logic.Interfaces
{
    public interface IHealthChanger
    {
        public int DeltaHealth { get; }
        public Type[] TypesToIgnore { get; }
        public bool CanChangeHealth(Type type, IHealth health);
    }
}
