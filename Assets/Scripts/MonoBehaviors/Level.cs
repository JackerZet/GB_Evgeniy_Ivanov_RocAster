using Logic.Infrastructure;
using Logic.Infrastructure.FactoryMethod;
using Logic.Infrastructure.ObjectPool;
using UnityEngine;

namespace BehaviorRealizations
{
    public sealed class Level : MonoBehaviour
    {
        #region Links
        [SerializeField] private Player playerPrefab;
        [SerializeField] private Bullet[] bulletPrefabs;
        [SerializeField] private Enemy[] enemyPrefabs;
        #endregion

        #region Fields
        private static IViewServices _viewServices;

        private readonly ICreator _creator = new GeneralCreator();
        
        private Player _player;
        private Enemy[] _enemies;
        #endregion

        #region Properties
        public static IViewServices Pools => _viewServices;
        #endregion

        #region MonoBehavior's methods
        private void OnEnable()
        {
            CreatePools();

            CreatePlayer();

            CreateObjects();
        }
        private void Update()
        {
            _player.ObjectUpdate();

            for(int i = 0; i < _enemies.Length; i++)   
                _enemies[i].ObjectUpdate();           
        }
        #endregion

        #region Functionality
        private void CreatePools()
        {
            GameObject[] gameObjects = new GameObject[bulletPrefabs.Length];

            for (int i = 0; i < bulletPrefabs.Length; i++)
                gameObjects[i] = bulletPrefabs[i].gameObject;

            _viewServices = new ObjectPoolsView(gameObjects);
        }
        private void CreatePlayer()
        {
            _player = _creator.FactoryMethod(playerPrefab);
        }
        private void CreateObjects()
        {           
            _enemies = new Enemy[enemyPrefabs.Length];

            for(int i = 0; i < enemyPrefabs.Length; i++)
                _enemies[i] = _creator.FactoryMethod(enemyPrefabs[i]);           
        }
        #endregion
    }
}
