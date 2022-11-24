using BehaviorRealizations;
using Logic.Infrastructure;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Generic
{
    public abstract class Shooting : IShooting
    {
        public Bullet Bullet { get; }
        public Transform Barrel { get; }
        public IViewServices ViewServices { get; }

        
        public Shooting(Bullet bullet, Transform barrel, IViewServices viewServices)
        {                     
            Bullet = bullet;
            Barrel = barrel;
            ViewServices = viewServices;
        }

        public abstract void Shoot();
        protected abstract void OnShoot();
    }
}
