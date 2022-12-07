using UnityEngine;

namespace Logic.Infrastructure.Builder
{
    public sealed class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject)
        { }
        public GameObjectPhysicsBuilder CircleCollider2D()
        {
            GetOrAddComponent<CircleCollider2D>();
            return this;
        }

        public GameObjectPhysicsBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }
        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();

            if (result)
                return result;

            return _gameObject.AddComponent<T>();
        }
    }
}
