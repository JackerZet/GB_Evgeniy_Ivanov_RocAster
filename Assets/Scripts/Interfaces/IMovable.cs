using UnityEngine;

namespace Logic.Interfaces
{
    public interface IMovable
    {
        public float Speed { get; }
        public void Move(Vector2 direcion = new Vector2());
    }
}
