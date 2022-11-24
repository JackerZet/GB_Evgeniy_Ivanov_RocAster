using BehaviorRealizations;
using Logic.Infrastructure;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Generic
{
    public class PlayerShooting : Shooting
    {      
        public PlayerShooting(Bullet bullet, Transform barrel, IViewServices viewServices) : base(bullet, barrel, viewServices)
        { }

        public override void Shoot()
        {
            if (Input.GetKeyDown(GameData.Keys.shoot))
            {
                OnShoot();
            }
        }

        protected override void OnShoot()
        {
            var bullet = ViewServices.Instantiate<Bullet>(Bullet.gameObject);

            bullet.transform.position = Barrel.position;

            bullet.Movable.Move();
        }
    }
}
