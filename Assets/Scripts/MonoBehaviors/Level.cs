using Logic.Game;
using Logic.Infrastructure.FactoryMethod;
using Logic.Infrastructure.ServiceLocator;
using ScriptableObjects;
using UnityEngine;

namespace BehaviorRealizations
{
    public sealed class Level : MonoBehaviour
    {
        #region Links
        [SerializeField] private Prefabs prefabs;
        #endregion

        #region Fields
        private static readonly ServiceLocator _serviceLocator = new();

        private readonly GameData _gameData = new();     
        #endregion

        #region Properties
        public static ServiceLocator ServiceLocator => _serviceLocator;
        #endregion

        #region MonoBehavior's methods
        private void Awake()
        {                                  
            new GameInitializer(prefabs, _gameData);
        }
        private void Update()
        {
            _gameData.player.OnUpdate();

            for(int i = 0; i < _gameData.enemies.Length; i++)
                _gameData.enemies[i].OnUpdate();           
        }
        private void LateUpdate()
        {
            _gameData.cameraController.Follow();
        }
        private void OnDisable()
        {
            _gameData.spawner.Dispose();
        }
        #endregion
    }
}
