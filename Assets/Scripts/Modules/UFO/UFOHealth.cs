using Logic.Generic;
using Logic.Interfaces;
using System;

namespace Logic.Players
{
    public class UFOHealth : HealthBase
    {
        public static event Action OnDeathUnitHandler;
        public UFOHealth(int maxHealth) : base(maxHealth)
        {
        }
        public override void ChangeHealth(IHealthChanger healthChanger)
        {
            base.ChangeHealth(healthChanger);

            if (Health < 0)
                OnDeathUnitHandler?.Invoke();
        }
    }
}
