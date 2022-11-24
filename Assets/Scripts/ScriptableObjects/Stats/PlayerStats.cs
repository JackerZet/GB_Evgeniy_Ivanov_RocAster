using BehaviorRealizations;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable objects/Stats/Player stats", order = 5)]
    public class PlayerStats : StatsBase
    {
        [field: SerializeField] public Bullet Bullet { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int MaxHealth { get; private set; }
    }
}
