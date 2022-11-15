
using UnityEngine;

namespace Logic.Interfaces
{
    public interface IShootable
    {
        public float Speed { get; }
        public void Fly(Vector2 direction);
    }
}