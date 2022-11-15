using Logic.Interfaces;

namespace Logic.Player
{
    public class PlayerHealth : IHealth
    {
        public int MaxHealth { get; }
        public int Health { get; private set; }
        
        public PlayerHealth(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public void ChangeHealth(IHealthChanger healthChanger)
        {
            Health -= healthChanger.DeltaHealth;
        }
    }  
}
