using Interfaces;
using UnityEngine;

namespace Characters
{
    public class EnemyCharacter : Character
    {
        [SerializeField] PlayerDetector _playerDetector;

        private IBehaviour _restBehaviour;
        private IBehaviour _reactionBehaviour;

        private bool _isReact;

        public void Initialize(IBehaviour restBehaviour, IBehaviour reactionBehaviour)
        {
            _restBehaviour = restBehaviour;
            _reactionBehaviour = reactionBehaviour;

            _playerDetector.Initialize(restBehaviour, reactionBehaviour);
        }

        private void Update()
        {
            if(_isReact)
                _reactionBehaviour.Update();
            else
                _restBehaviour.Update();
        }
    }
}
