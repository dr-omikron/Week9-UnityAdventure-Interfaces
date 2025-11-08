using Characters;
using Interfaces;
using UnityEngine;

namespace Game
{
    public class EnemySpawner : MonoBehaviour
    {
        private EnemyCharacter _enemyCharacterPrefab;
        private EnemySpawnPoint[] _spawnPoints;

        private void Awake()
        {
            _spawnPoints = GetComponentsInChildren<EnemySpawnPoint>();
        }

        public void Initialize(EnemyCharacter enemyPrefab)
        {
            _enemyCharacterPrefab = enemyPrefab;
        }

        public void Spawn()
        {
            foreach (var spawnPoint in _spawnPoints)
            {
                EnemyCharacter enemy = Instantiate(_enemyCharacterPrefab, spawnPoint.transform.position, Quaternion.identity);
                BehaviourFactory behaviourFactory = new BehaviourFactory();

                IRestBehaviour restBehaviour = behaviourFactory.GetEnemyRestBehaviour(spawnPoint.RestBehaviour);
                IReactionBehaviour reactionBehaviour = behaviourFactory.GetEnemyReactionBehaviour(spawnPoint.ReactionBehaviour);

                enemy.Initialize(restBehaviour, reactionBehaviour);
            }
        }
    }
}
