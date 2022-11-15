using Logic.Interfaces;
using Logic.Player;
using UnityEngine;

namespace BehaviorRealizations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private int maxHealth = 10;
        [SerializeField] private int damage = 2;
        [SerializeField] private Bullet bullet = null;

        public IShooting Shooting => _shooting;

        private IMovable _managment;
        private IHealth _health;
        private IShooting _shooting;

        public void Init()
        {
            _managment = new PlayerManagment(GetComponent<Rigidbody2D>(), speed);
            _health = new PlayerHealth(maxHealth);

            if (bullet != null)
                _shooting = new PlayerShooting(damage, bullet);
        }
        public void PlayerUpdate()
        {           
            _managment.Move(Input.GetAxis(ConstData.Horizontal), Input.GetAxis(ConstData.Vertical), Time.deltaTime);
            _shooting.Shoot();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent(out IHealthChanger healthChanger))
            {
                _health.ChangeHealth(healthChanger);
                Debug.Log(_health.Health);
                
            }
        }
    }
}
