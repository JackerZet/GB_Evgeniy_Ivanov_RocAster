using Logic.Bullets;
using Logic.Infrastructure;
using Logic.Interfaces;
using ScriptableObjects;
using System;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Bullet : MonoBehaviour, IHasMoving, IHasHealthChanger, IInitable
    {
        [SerializeField] private BulletStats stats;
        
        protected IMovable _shootable;
        protected IHealthChanger _healthChanger;

        public IMovable Movable => _shootable;
        public IHealthChanger HealthChanger => _healthChanger;

        protected Type[] _typesToIgnore;
        public void Init()
        {
            SetTypeToIgnore();
           
            _healthChanger = new BulletHitting(stats.Damage, _typesToIgnore);
            _shootable = new BulletFlying(GetComponent<Rigidbody2D>(), stats.Speed);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            for (int i = 0; i < _typesToIgnore.Length; i++)
            {
                if (!collision.gameObject.TryGetComponent(_typesToIgnore[i], out Component _))
                {                                  
                    Level.Pools.Destroy(gameObject);
                   
                    return;
                }
            }
        }
        protected abstract void SetTypeToIgnore();
    }
}
