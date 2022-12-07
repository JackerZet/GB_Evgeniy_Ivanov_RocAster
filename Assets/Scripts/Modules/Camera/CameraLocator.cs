using Unity.VisualScripting;
using UnityEngine;

namespace Logic.Game
{
    public static class CameraLocator
    {   
        #region Properties
        public static CameraMoving CameraController
        {
            get
            {
                var camera = Camera.main;

                if(camera == null)                
                    return Object.Instantiate(Camera.main).AddComponent<CameraMoving>();
                
                if(camera.TryGetComponent(out CameraMoving controller))                
                    return controller;
                
                return camera.AddComponent<CameraMoving>();
            }
        }
        #endregion
    }
}
