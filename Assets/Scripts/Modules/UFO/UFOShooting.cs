using BehaviorRealizations;
using Logic.Generic;
using Logic.Infrastructure;
using UnityEngine;
namespace Logic.Enemies.UFO
{
    public class UFOShooting : Shooting
    {
        private readonly Transform _target;
        private readonly Enumerator _enumerator;

        private const float timeoutShoot = 1f;
        public UFOShooting(Bullet bullet, Transform barrel, IViewServices viewServices, Transform target) : base(bullet, barrel, viewServices)
        {
            _target = target;
            _enumerator = new Enumerator(timeoutShoot);
        }

        public override void Shoot()
        {
            if (_enumerator.CanDo()) 
                OnShoot();
        }

        protected override void OnShoot()
        {
            Vector2 direction = _target.position - Barrel.position;

            float dotRight = direction.x;
            float dotUp = direction.y;
            
            if(dotRight > 0)
            
                if(dotUp > 0)
                
                    if(dotUp > dotRight)
                        Impulse(Vector2.up);
                    
                    else
                        Impulse(Vector2.right);
                                  
                else
                
                    if (-dotUp > dotRight)                   
                        Impulse(Vector2.down);
                    
                    else                   
                        Impulse(Vector2.right);
                               
            else
            
                if (dotUp > 0)
                
                    if (dotUp > -dotRight)                   
                        Impulse(Vector2.up);
                    
                    else                   
                        Impulse(Vector2.left);
                                   
                else
                
                    if (-dotUp > -dotRight)                  
                        Impulse(Vector2.down);
                    
                    else                   
                       Impulse(Vector2.left);             
        }
        private void Impulse(Vector2 direction)
        {
            var bullet = ViewServices.Instantiate<Bullet>(Bullet.gameObject);

            bullet.transform.position = (Vector2)Barrel.position + direction;

            bullet.Movable.Move(direction);
        }   
    }
}