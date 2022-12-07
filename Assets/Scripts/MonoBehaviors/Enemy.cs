using Logic.Interfaces;
using UnityEngine;

namespace BehaviorRealizations
{
    public abstract class Enemy : MonoBehaviour, IHasHealthChanger, IUpdateable
    {
        protected IHealthChanger _hitting;
        public IHealthChanger HealthChanger => _hitting;

        public abstract void Awake();
        public abstract void OnUpdate();
    }
}
