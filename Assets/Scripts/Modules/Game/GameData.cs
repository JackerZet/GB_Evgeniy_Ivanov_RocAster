using BehaviorRealizations;
using Logic.Actions;

namespace Logic.Game
{
    public sealed class GameData
    {
        public CameraMoving cameraController;
        public Spawner spawner;
        public Player player;
        public Enemy[] enemies;
        //private readonly List<IUpdateable> _updateables = new();
    }
}