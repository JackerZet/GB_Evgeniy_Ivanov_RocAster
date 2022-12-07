using Logic.Enemies.UFO;
using Logic.Generic;
using Logic.Infrastructure.Prototype;
using Logic.Interfaces;
using Logic.Players;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    public class UFO : Enemy, IHasMoving, IHasHealth, IPrototype
    {
        [SerializeField] private UFOStats stats;
        
        private IMovable _movable;
        private IShooting _shooting;
        private IHealth _health;

        public IMovable Movable => _movable;
        public IHealth Health => _health;

        public override void Awake()
        {
            if (!stats)
                stats = Resources.Load<UFOStats>(Const.ScriptableObjectsPath + nameof(UFOStats));

            _movable = new UFOMoving(GetComponent<Rigidbody2D>(), stats.Speed);
            _health = new UFOHealth(stats.MaxHealth);
            _hitting = new Hitting(stats.Damage, typeof(UFO));
            _shooting = new UFOShooting(stats.Bullet, transform, FindObjectOfType<Player>().transform);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IHasHealthChanger healthChanger))
            {
                healthChanger.HealthChanger.CanChangeHealth(GetType(), _health);

                Debug.Log(nameof(UFO) + _health.Health);
            }
        }
        public override void OnUpdate()
        {
            _movable.Move();
            _shooting.Shoot();
        }
        public IPrototype ShallowCopy()
        {
            return (UFO) MemberwiseClone();
        }

        public IPrototype DeepCopy()
        {
            UFO clone = (UFO)MemberwiseClone();
            clone.stats = stats;
            return clone;
        }
    }
}
