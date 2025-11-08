using Types;
using UnityEngine;

namespace Game
{
    public class EnemySpawnPoint : MonoBehaviour
    {
        [SerializeField] private RestBehaviourTypes _restBehaviour;
        [SerializeField] private ReactionBehaviourTypes _reactionBehaviour;

        public RestBehaviourTypes RestBehaviour => _restBehaviour;
        public ReactionBehaviourTypes ReactionBehaviour => _reactionBehaviour;
    }
}
