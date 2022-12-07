using System;
using System.Collections.Generic;
using UnityEngine;

namespace Logic.Infrastructure.ObjectPool
{
    public class ObjectPool : IDisposable
    {
        private readonly Stack<GameObject> _objects = new();

        private readonly Transform _root;
        private readonly GameObject _prefab;
        
        public int Count => _objects.Count;
        
        public ObjectPool(GameObject prefab, int initCount = 1)
        {           
            _prefab = prefab;
            _root = new GameObject($"[{prefab.name}]").transform;
                       
            for(int i = 0; i < initCount; i++)
            {
                var obj = Instantiate();

                Push(obj);
            }       
        }

        public GameObject Pop()
        {
            if (_objects.Count == 0)
            {
                return Instantiate();
            }

            var obj = _objects.Pop();
          
            obj.SetActive(true);
            obj.transform.SetParent(null);
            return obj;
        }
        public void Push(GameObject obj)
        {          
            obj.SetActive(false);
            obj.transform.SetParent(_root);
            _objects.Push(obj);
        }
        private GameObject Instantiate()
        {
            var gameObject = UnityEngine.Object.Instantiate(_prefab);

            gameObject.name = _prefab.name;
            return gameObject;
        }
        
        public void Dispose()
        {
            while(_objects.Count > 0)
            {
                UnityEngine.Object.Destroy(_objects.Pop());
            }
            UnityEngine.Object.Destroy(_root);
        }
    }   
}
