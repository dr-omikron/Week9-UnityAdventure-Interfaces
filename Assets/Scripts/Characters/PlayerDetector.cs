using Interfaces;
using UnityEngine;

namespace Characters
{
    public class PlayerDetector : MonoBehaviour
    {
        [SerializeField] SphereCollider _collider;

        private IBehaviour _restBehaviour;
        private IBehaviour _reactionBehaviour;
        private IBehaviour _currentBehaviour;

        public void Initialize(IBehaviour restBehaviour, IBehaviour reactionBehaviour)
        {
            _restBehaviour = restBehaviour;
            _reactionBehaviour = reactionBehaviour;

            _currentBehaviour = _restBehaviour;
        }

        private void Update()
        {
            _currentBehaviour.Update();
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerCharacter playerCharacter = other.GetComponent<PlayerCharacter>();

            if (playerCharacter != null)
                SwitchBehaviour(_reactionBehaviour);
        }

        private void OnTriggerExit(Collider other)
        {
            PlayerCharacter playerCharacter = other.GetComponent<PlayerCharacter>();

            if (playerCharacter != null)
                SwitchBehaviour(_restBehaviour);
        }

        private void SwitchBehaviour(IBehaviour behaviour)
        {
            _currentBehaviour.Exit();
            _currentBehaviour = behaviour;
            _currentBehaviour.Enter();
        }
    }
}
