using Interfaces;
using UnityEngine;

namespace Characters
{
    public class EnemyCharacter : Character
    {
        [SerializeField] PlayerDetector _playerDetector;

        public void Initialize(IBehaviour restBehaviour, IBehaviour reactionBehaviour)
        {
            _playerDetector.Initialize(restBehaviour, reactionBehaviour);
        }
    }
}
