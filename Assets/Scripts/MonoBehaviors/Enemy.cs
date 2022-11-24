using Logic.Interfaces;
using UnityEngine;

namespace BehaviorRealizations
{
    public abstract class Enemy : MonoBehaviour, IHasHealthChanger, IInitable
    {
        protected IHealthChanger _hitting;
        public IHealthChanger HealthChanger => _hitting;
        
        public abstract void Init();
        public abstract void ObjectUpdate();
    }
}
