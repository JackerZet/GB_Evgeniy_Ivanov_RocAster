using Logic.Bullets;
using Logic.Interfaces;
using ScriptableObjects;
using System;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Bullet : MonoBehaviour, IHasMoving, IHasHealthChanger, IUpdateable
    {
        [SerializeField] protected BulletStats stats;
        
        protected IMovable _shootable;
        protected IHealthChanger _healthChanger;
        private IDestroyable _destroying;

        public IMovable Movable => _shootable;
        public IHealthChanger HealthChanger => _healthChanger;


        protected Type[] _typesToIgnore;

        protected virtual void Awake()
        {
            SetTypeToIgnore();

            //_destroying = new BulletDestroying(gameObject, Level.ServiceLocator[typeof(ObjectPoolsView)]);
            _healthChanger = new BulletHitting(stats.Damage, _typesToIgnore);
            _shootable = new BulletFlying(GetComponent<Rigidbody2D>(), stats.Speed);
        }

        public void OnUpdate()
        {
            _shootable.Move();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            for (int i = 0; i < _typesToIgnore.Length; i++)
            {
                if (!collision.gameObject.TryGetComponent(_typesToIgnore[i], out Component _))
                {                                  
                   // _destroying.Destroy();
                   
                    return;
                }
            }
        }
        protected abstract void SetTypeToIgnore();
    }
}
