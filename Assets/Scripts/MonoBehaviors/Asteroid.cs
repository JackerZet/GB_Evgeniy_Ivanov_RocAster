using Logic.Generic;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    public class Asteroid : Enemy
    {
        [SerializeField] private AsteroidStats stats;

        public override void Awake()
        {      
            if (!stats)
                stats = Resources.Load<AsteroidStats>(Const.ScriptableObjectsPath + nameof(AsteroidStats));

            _hitting = new Hitting(stats.Damage);
        }

        public override void OnUpdate() { }
    }
}
