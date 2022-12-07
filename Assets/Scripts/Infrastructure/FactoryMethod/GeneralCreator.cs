using UnityEngine;

namespace Logic.Infrastructure.FactoryMethod
{
    public sealed class GeneralCreator : ICreator
    {
        public T FactoryMethod<T>(T prefab) where T : MonoBehaviour
        {
            T gameObject = Object.Instantiate(prefab);

            return gameObject;
        }
    }
}
