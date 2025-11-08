using UnityEngine;
using Characters;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerCharacter _playerPrefab;
        [SerializeField] private InputManager _inputManager;
        [SerializeField] private Transform _playerStartPoint;

        [SerializeField] private EnemyCharacter _enemyPrefab;
        [SerializeField] private EnemySpawner _enemySpawner;

        private PlayerCharacter _playerCharacter;

        private void Awake()
        {
            _playerCharacter = Instantiate(_playerPrefab, _playerStartPoint.position, Quaternion.identity);
            _playerCharacter.Initialize(_inputManager);

            _enemySpawner.Initialize(_enemyPrefab);
            _enemySpawner.Spawn();
        }
    }
}
