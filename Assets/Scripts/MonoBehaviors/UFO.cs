using Logic.Enemies.UFO;
using Logic.Generic;
using Logic.Interfaces;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    public class UFO : Enemy, IHasMoving
    {
        [SerializeField] private UFOStats stats;
        
        private IMovable _movable;
        private IShooting _shooting;

        public IMovable Movable => _movable;
        
        public override void Init()
        {
            _movable = new UFOMoving(GetComponent<Rigidbody2D>(), stats.Speed);
            _hitting = new Hitting(stats.Damage, typeof(UFO));
            _shooting = new UFOShooting(stats.Bullet, transform, Level.Pools, FindObjectOfType<Player>().transform);
        }

        public override void ObjectUpdate()
        {
            _movable.Move();
            _shooting.Shoot();
        }
    }
}
