using BehaviorRealizations;
using Logic.Generic;
using Logic.Infrastructure.ObjectPool;
using UnityEngine;

namespace Logic.Players
{
    public class PlayerShooting : Shooting
    {
       
        public PlayerShooting(Bullet bullet, Transform barrel) : base(bullet, barrel)
        { }                  

        public override void Shoot()
        {
            if (Input.GetKeyDown(Const.Keys.shoot))
            {
                OnShoot();
            }
        }

        protected override void OnShoot()
        {
            var direction = new Vector2Int
            {
                x = (int)Input.GetAxis(Const.Horizontal),
                y = (int)Input.GetAxis(Const.Vertical)
            };
            Debug.Log(direction);
            Impulse(direction);
        }
        private void Impulse(Vector2 direction)
        {
            var bullet = Level.ServiceLocator[typeof(ObjectPoolsView)].Instantiate<Bullet>(Bullet.gameObject);

            bullet.transform.position = (Vector2) Barrel.position + direction;

            bullet.Movable.Move();
        }
    }
}
