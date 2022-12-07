using BehaviorRealizations;
using Logic.Infrastructure.Prototype;
using Logic.Players;
using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Logic.Actions
{
    public class Spawner : IDisposable
    {
        #region Fields
        private readonly IPrototype _cloneble;
        #endregion

        #region Constructors
        public Spawner(IPrototype gameObject)
        {
            _cloneble = gameObject;
            UFOHealth.OnDeathUnitHandler += OnDeath;
        }
        public void Dispose()
        {
            UFOHealth.OnDeathUnitHandler -= OnDeath;
        }
        #endregion

        #region Functionality
        public void OnDeath()
        {
            Object.Instantiate(Spawn<UFO>());
            Object.Instantiate(Spawn<UFO>());
        }
        public T Spawn<T>(Vector2 positionToSpawn = new Vector2()) where T : UnityEngine.Component , IPrototype
        {                      
            T clone = (T)_cloneble.DeepCopy();

            clone.transform.position = positionToSpawn;
           
            return clone;
        }
        #endregion
    }
}
