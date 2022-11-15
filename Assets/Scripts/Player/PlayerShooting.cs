using BehaviorRealizations;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Player
{
    public class PlayerShooting : IShooting
    {
        public int DeltaHealth { get; }
        public IShootable Shootable { get; }

        public PlayerShooting(int deltaHealth, Bullet bullet)
        {
            DeltaHealth = deltaHealth;
            Shootable = bullet;
        }

        public void Shoot()
        {
            if (Input.GetKeyDown(ConstData.Keys.shoot))
            {
                OnShoot();
            }
        }

        private void OnShoot()
        {
            Debug.Log("piu");
        }
    }
}
