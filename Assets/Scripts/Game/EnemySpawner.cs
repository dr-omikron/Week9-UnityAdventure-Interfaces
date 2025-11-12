using System.Collections.Generic;
using Characters;
using Interfaces;
using UnityEngine;

namespace Game
{
    public class EnemySpawner : MonoBehaviour
    {
        private EnemyCharacter _enemyCharacterPrefab;
        private PlayerCharacter _playerCharacter;
        private EnemySpawnPoint[] _spawnPoints;
        private List<Vector3> _patrolPoints;

        private BehaviourDeterminer _behaviourDeterminer;

        private void Awake()
        {
             _spawnPoints = GetComponentsInChildren<EnemySpawnPoint>();
        }

        public void Initialize(PlayerCharacter playerCharacter, EnemyCharacter enemyPrefab, List<Vector3> patrolPoints)
        {
            _enemyCharacterPrefab = enemyPrefab;
            _playerCharacter = playerCharacter;
            _patrolPoints = patrolPoints;

            _behaviourDeterminer = new BehaviourDeterminer();
        }

        public void Spawn()
        {
            foreach (var spawnPoint in _spawnPoints)
            {
                EnemyCharacter enemy = Instantiate(_enemyCharacterPrefab, spawnPoint.transform.position, Quaternion.identity);

                IBehaviour restBehaviour = _behaviourDeterminer.GetEnemyRestBehaviour(spawnPoint.RestBehaviour, _patrolPoints, enemy);
                IBehaviour reactionBehaviour = _behaviourDeterminer.GetEnemyReactionBehaviour(spawnPoint.ReactionBehaviour, enemy, _playerCharacter);

                enemy.Initialize(restBehaviour, reactionBehaviour);
            }
        }
    }
}
