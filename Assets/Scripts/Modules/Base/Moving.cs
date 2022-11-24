using Logic.Interfaces;
using UnityEngine;

namespace Logic.Generic
{
    public abstract class Moving : IMovable
    {
        public float Speed { get; }
        public Rigidbody2D Rigidbody { get; }

        public Moving(Rigidbody2D rigidbody, float speed)
        {
            Rigidbody = rigidbody;
            Speed = speed;
        }
        public abstract void Move(Vector2 direction = new Vector2());
    }
}