using UnityEngine;

namespace Logic.Infrastructure.Builder
{
    public class GameObjectBuilder
    {
        #region Fields
        protected GameObject _gameObject;
        #endregion

        #region Properties
        public GameObjectVisualBuilder Visual => new(_gameObject);
        public GameObjectPhysicsBuilder Physics => new(_gameObject);
        #endregion

        #region Constructors
        public GameObjectBuilder() => _gameObject = new GameObject();
        protected GameObjectBuilder(GameObject gameObject) => _gameObject = gameObject;
        #endregion 

        #region Functionality
        public static implicit operator GameObject(GameObjectBuilder builder)
        {
            return builder._gameObject;
        }
        #endregion 
    }
}
