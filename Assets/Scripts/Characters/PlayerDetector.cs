using Interfaces;
using UnityEngine;

namespace Characters
{
    public class PlayerDetector : MonoBehaviour
    {
        [SerializeField] SphereCollider _collider;

        private IBehaviour _restBehaviour;
        private IBehaviour _reactionBehaviour;

        public void Initialize(IBehaviour restBehaviour, IBehaviour reactionBehaviour)
        {
            _restBehaviour = restBehaviour;
            _reactionBehaviour = reactionBehaviour;
        }
        private void OnTriggerEnter(Collider other)
        {
            PlayerCharacter playerCharacter = other.GetComponent<PlayerCharacter>();

            if (playerCharacter != null)
            {
                _restBehaviour.Exit();
                _reactionBehaviour.Enter();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            PlayerCharacter playerCharacter = other.GetComponent<PlayerCharacter>();
            
            if (playerCharacter != null)
            {
                _restBehaviour.Enter();
                _reactionBehaviour.Exit();
            }
        }
    }
}
