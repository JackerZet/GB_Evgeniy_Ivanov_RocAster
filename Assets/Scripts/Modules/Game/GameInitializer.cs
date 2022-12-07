using Logic.Infrastructure.FactoryMethod;
using Logic.Infrastructure.ObjectPool;
using ScriptableObjects;
using UnityEngine;
using BehaviorRealizations;
using Logic.Actions;

namespace Logic.Game
{
    public sealed class GameInitializer
    {
        private readonly Prefabs _prefabs;      
        private readonly GameData _data;
        private readonly ICreator _creator = new GeneralCreator();
        public GameInitializer(Prefabs prefabs, GameData data)
        {
            _prefabs = prefabs;
            _data = data;

            _data.cameraController = CameraLocator.CameraController;

            CreateSpawners();
            CreatePools();
            CreatePlayer();         
            CreateEnemies();           
        }
        private void CreateSpawners()
        {
            if (_prefabs.UFOs.Length == 0) return;

            _data.spawner = new Spawner(_prefabs.UFOs[0]);
        }
        private void CreatePools()
        {
            GameObject[] gameObjects = new GameObject[_prefabs.Bullets.Length];

            for (int i = 0; i < _prefabs.Bullets.Length; i++)
                gameObjects[i] = _prefabs.Bullets[i].gameObject;

            Level.ServiceLocator[typeof(ObjectPoolsView)] = new ObjectPoolsView(gameObjects);
        }
        private void CreatePlayer()
        {
            _data.player = _creator.FactoryMethod(_prefabs.Player);
            _data.cameraController.Target = _data.player.transform;
        }
        private void CreateEnemies()
        {
            int length = _prefabs.Asteroids.Length + _prefabs.UFOs.Length;

            _data.enemies = new Enemy[length];

            for (int i = 0; i < _prefabs.Asteroids.Length; i++)
                _data.enemies[i] = _creator.FactoryMethod(_prefabs.Asteroids[i]);

            for (int i = 0; i < _prefabs.UFOs.Length; i++)
                _data.enemies[i + _prefabs.Asteroids.Length] = _creator.FactoryMethod(_prefabs.UFOs[i]);
        }
    }
}