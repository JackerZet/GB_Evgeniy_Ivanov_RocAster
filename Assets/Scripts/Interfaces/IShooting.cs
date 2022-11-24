using BehaviorRealizations;
using UnityEngine;

namespace Logic.Interfaces
{
    public interface IShooting
    {
        public Bullet Bullet { get; }
        public Transform Barrel { get; }
        public void Shoot();
    }
}
