using BehaviorRealizations;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "UFOStats", menuName = "Scriptable objects/Stats/UFO stats", order = 8)]
    public class UFOStats : StatsBase
    {
        [field: SerializeField] public Bullet Bullet { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }
        [field: SerializeField] public int MaxHealth { get; private set; }

    }
   
}
