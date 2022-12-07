using BehaviorRealizations;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "PrefabsForLevel", menuName = "Scriptable objects/PrefabsForLevel", order = 1)]
    public class Prefabs : ScriptableObject
    {
        #region Links
        [field: SerializeField] public Player Player { get; private set; }
        [field: SerializeField] public Bullet[] Bullets { get; private set; }
        [field: SerializeField] public Asteroid[] Asteroids { get; private set; }
        [field: SerializeField] public UFO[] UFOs { get; private set; }

        #endregion
    }
}
