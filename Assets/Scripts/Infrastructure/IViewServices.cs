using UnityEngine;

namespace Logic.Infrastructure
{
    public interface IViewServices
    {
        T Instantiate<T>(GameObject gameObject);
        void Destroy(GameObject gameObject);
    }
}
