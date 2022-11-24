using System.Collections.Generic;
using UnityEngine;

namespace Logic.Infrastructure.ObjectPool
{
    public class ObjectPoolsView : IViewServices
    {
        private readonly Dictionary<string, ObjectPool> _pools = new();

        public ObjectPoolsView(params GameObject[] gameObjects)
        {
            for(int i = 0; i < gameObjects.Length; i++)
            {
                _pools.Add(gameObjects[i].name, new ObjectPool(gameObjects[i], 10));
            }
        }
        public T Instantiate<T>(GameObject gameObject)
        {
            if(!_pools.TryGetValue(gameObject.name, out ObjectPool pool))
            {
                pool = new ObjectPool(gameObject);
                _pools[gameObject.name] = pool;
            }
            if(pool.Pop().TryGetComponent(out T component))
            {
                return component;
            }
            throw new System.InvalidOperationException($"{typeof(T)} not found");
        }
        public void Destroy(GameObject gameObject)
        {
            _pools[gameObject.name].Push(gameObject);
        }

        
    }
}
