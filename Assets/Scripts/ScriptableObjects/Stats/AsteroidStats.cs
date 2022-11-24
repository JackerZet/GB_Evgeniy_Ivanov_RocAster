using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "AsteroidStats", menuName = "Scriptable objects/Stats/Asteroid stats", order = 7)]
    public class AsteroidStats : StatsBase
    {        
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public int Damage { get; private set; }

    }
   
}
