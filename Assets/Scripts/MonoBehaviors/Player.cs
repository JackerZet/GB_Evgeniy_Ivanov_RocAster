using Logic.Generic;
using Logic.Interfaces;
using Logic.Player;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour, IInitable
    {
        [SerializeField] private PlayerStats stats;

        private IMovable _managment;
        private IHealth _health;
        private IShooting _shooting;

        public void Init()
        {
            _managment = new PlayerManagment(GetComponent<Rigidbody2D>(), stats.Speed);
            _health = new PlayerHealth(stats.MaxHealth);

            if (stats.Bullet != null)
            {
                _shooting = new PlayerShooting(stats.Bullet, transform, Level.Pools);
            }
        }
        public void ObjectUpdate()
        {           
            _managment.Move();
            _shooting.Shoot();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IHasHealthChanger healthChanger))
            {
                healthChanger.HealthChanger.CanChangeHealth(GetType(), _health);
                
                Debug.Log(_health.Health);
            }
        }
    }
}
