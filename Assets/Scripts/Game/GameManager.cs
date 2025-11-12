using System.Collections.Generic;
using UnityEngine;
using Characters;
using FunctionsLibrary;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerCharacter _playerPrefab;
        [SerializeField] private InputManager _inputManager;
        [SerializeField] private Transform _playerStartPoint;

        [SerializeField] private EnemyCharacter _enemyPrefab;
        [SerializeField] private EnemySpawner _enemySpawner;
        [SerializeField] private List<Transform> _patrolPoints;

        private PlayerCharacter _playerCharacter;

        private void Awake()
        {
            _playerCharacter = Instantiate(_playerPrefab, _playerStartPoint.position, Quaternion.identity);
            _playerCharacter.Initialize(_inputManager);

            List<Vector3> patrolPointsPositions = StaticFunctions.GetPositionsFromTransforms(_patrolPoints);

            _enemySpawner.Initialize(_playerCharacter, _enemyPrefab, patrolPointsPositions);
            _enemySpawner.Spawn();
        }
    }
}
