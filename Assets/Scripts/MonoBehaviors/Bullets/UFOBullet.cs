using ScriptableObjects;
using System;
using UnityEngine;

namespace BehaviorRealizations
{
    public class UFOBullet : Bullet
    {
        protected override void Awake()
        {
            if (!stats)
                stats = Resources.Load<BulletStats>(Const.ScriptableObjectsPath + "UFOBulletStats");

            base.Awake();
        }

        protected override void SetTypeToIgnore()
        {
            _typesToIgnore = new Type[]
            {
                typeof(UFO),
            };
        }
    }
}
