using UnityEngine;

namespace Logic.Interfaces
{
    public interface IMovable
    {
        public float Speed { get; }
        public void Move(float horisontalAxis, float verticalAxis, float deltaTime = 1);
    }
}
