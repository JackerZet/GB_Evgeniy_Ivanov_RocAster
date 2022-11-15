using Logic.Interfaces;
using UnityEngine;

namespace Logic.Health
{
    public class Asteroid : MonoBehaviour, IHealthChanger
    {
        [field: SerializeField] public int DeltaHealth { get; private set; }
    }
}
