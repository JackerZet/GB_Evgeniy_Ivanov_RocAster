using UnityEngine;

namespace BehaviorRealizations
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private Player playerPrefab;

        private Player _player;
        private void OnEnable()
        {
            _player = Instantiate(playerPrefab.gameObject).GetComponent<Player>();
            _player.Init();
        }
        private void Update()
        {
            _player.PlayerUpdate();
        }
    }
}
