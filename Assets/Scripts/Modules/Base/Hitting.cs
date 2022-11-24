using Logic.Interfaces;
using System;

namespace Logic.Generic
{
    public class Hitting : IHealthChanger
    {
        public int DeltaHealth { get; }
        public Type[] TypesToIgnore { get; }
        public Hitting(int damage, params Type[] typesIgnore)
        {
            DeltaHealth = damage;
            TypesToIgnore = typesIgnore;
        }

        public virtual bool CanChangeHealth(Type type, IHealth health)
        {
            for (int i = 0; i < TypesToIgnore.Length; i++)           
                if (TypesToIgnore[i] == type)                                  
                    return false;
                      
            health.ChangeHealth(this);
            return true;
        }
    }
}
