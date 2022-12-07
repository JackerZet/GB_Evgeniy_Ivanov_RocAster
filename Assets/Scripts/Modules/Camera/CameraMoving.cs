using UnityEngine;
using static UnityEngine.Mathf;

namespace Logic.Game
{
    public sealed class CameraMoving : MonoBehaviour
    {
        #region Const
        private const float cameraDelay = 0.02f;
        #endregion

        #region Fields
        private Transform _target;
        private Vector3 _direction;
        #endregion

        #region Properties
        public Transform Target { set => _target = value; }
        #endregion

        #region Functionality
        public void Follow()
        {
            _direction.x = Lerp(_direction.x, _target.position.x, cameraDelay);
            _direction.y = Lerp(_direction.y, _target.position.y, cameraDelay);
            _direction.z = -1;
            transform.position = _direction;
        }
        #endregion   
    }
}
