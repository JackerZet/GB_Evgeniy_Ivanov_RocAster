using ScriptableObjects;
using System;
using UnityEngine;

namespace BehaviorRealizations
{
    public class PlayerBullet : Bullet
    {
        protected override void Awake()
        {
            if (!stats)
                stats = Resources.Load<BulletStats>(Const.ScriptableObjectsPath + "PlayerBulletStats");

            base.Awake();
        }
        protected override void SetTypeToIgnore()
        {
            _typesToIgnore = new Type[]
            {
                typeof(Player),
            };
        }
    }
}
