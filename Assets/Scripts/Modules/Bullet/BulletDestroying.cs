using Logic.Infrastructure;
using Logic.Interfaces;
using UnityEngine;

namespace Logic.Bullets
{
    public class BulletDestroying : IDestroyable
    {
        #region Fields
        private readonly IService _service;
        private readonly GameObject _bullet;
        #endregion

        #region Constructor
        public BulletDestroying(GameObject bullet, IService bulletService)
        {
            _service = bulletService;
            _bullet = bullet;
        }
        #endregion

        #region Functionality
        public void Destroy()
        {
            _service.Destroy(_bullet);
        }
        #endregion
    }
}
