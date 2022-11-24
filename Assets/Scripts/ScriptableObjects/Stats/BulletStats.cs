using System;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "BulletStats", menuName = "Scriptable objects/Stats/Bullet stats", order = 6)]
    public class BulletStats : StatsBase
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }
    }
}
