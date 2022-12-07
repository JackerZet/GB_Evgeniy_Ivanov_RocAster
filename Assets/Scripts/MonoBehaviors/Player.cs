using Logic.Interfaces;
using Logic.Players;
using ScriptableObjects;
using System;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour, IUpdateable, IDisposable
    {        
        [SerializeField] private PlayerStats stats;

        #region Fields
        private IMovable _managment;
        private IHealth _health;
        private IShooting _shooting;
        #endregion

        #region MonoBehavior's methods
        private void Awake()
        {
            if (!stats)
                stats = Resources.Load<PlayerStats>(Const.ScriptableObjectsPath + nameof(PlayerStats));
            
            _managment = new PlayerMoving(GetComponent<Rigidbody2D>(), stats.Speed);
            _health = new PlayerHealth(stats.MaxHealth);

            if (stats.Bullet != null)
            {
                _shooting = new PlayerShooting(stats.Bullet, transform);
            }
        }
        #endregion

        public void Dispose()
        {
            _managment = null;
            _health = null;
            _shooting = null;
        }
        public void OnUpdate()
        {           
            _managment.Move();
            _shooting.Shoot();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IHasHealthChanger healthChanger))
            {
                healthChanger.HealthChanger.CanChangeHealth(GetType(), _health);
                
                Debug.Log(nameof(Player) + _health.Health);
            }
        }
    }
}
