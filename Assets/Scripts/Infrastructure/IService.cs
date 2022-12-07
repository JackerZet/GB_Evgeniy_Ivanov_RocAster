using UnityEngine;

namespace Logic.Infrastructure
{
    public interface IService
    {
        T Instantiate<T>(GameObject gameObject);
        void Destroy(GameObject gameObject);
    }
}
