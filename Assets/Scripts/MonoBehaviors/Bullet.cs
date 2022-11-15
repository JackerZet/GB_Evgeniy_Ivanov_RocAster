using Logic.Interfaces;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour, IShootable
    {
        [field:SerializeField] public float Speed { get; private set; }

        private Rigidbody2D _rigidbody;
        public void Init()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        public void Fly(Vector2 direction)
        {
            _rigidbody.velocity = Speed * Time.deltaTime * direction;
        }
    }
}
