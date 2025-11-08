using Interfaces;

namespace Characters
{
    public class EnemyCharacter : Character
    {
        private IRestBehaviour _restBehaviour;
        private IReactionBehaviour _reactionBehaviour;

        public void Initialize(IRestBehaviour restBehaviour, IReactionBehaviour reactionBehaviour)
        {
            _restBehaviour = restBehaviour;
            _reactionBehaviour = reactionBehaviour;
        }
    }
}
