using Logic.Generic;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    public class Asteroid : Enemy
    {
        [SerializeField] private AsteroidStats stats;

        public override void Init()
        {
            _hitting = new Hitting(stats.Damage);
        }

        public override void ObjectUpdate() { }
    }
}
