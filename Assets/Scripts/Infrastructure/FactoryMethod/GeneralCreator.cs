using BehaviorRealizations;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Infrastructure.FactoryMethod
{
    public sealed class GeneralCreator : ICreator
    {
        public T FactoryMethod<T>(T prefab) where T : MonoBehaviour, IInitable
        {
            T gameObject = Object.Instantiate(prefab);

            if(gameObject.TryGetComponent(out IInitable initable))
                initable.Init();

            return gameObject;
        }
    }
}
