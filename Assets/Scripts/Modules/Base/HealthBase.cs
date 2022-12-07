using Logic.Interfaces;

namespace Logic.Generic
{
    public class HealthBase : IHealth
    {
        public int MaxHealth { get; }
        public int Health { get; private set; }
      
        public HealthBase(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public virtual void ChangeHealth(IHealthChanger healthChanger)
        {
            Health -= healthChanger.DeltaHealth;          
        }
    }
}
