using Characters;
using Interfaces;

namespace Behaviours
{
    public class RunawayBehaviour : IBehaviour
    {
        private readonly Character _runawayTarget;
        private readonly Character _behaviourTarget;

        public RunawayBehaviour(Character runawayTarget, Character behaviourTarget)
        {
            _runawayTarget = runawayTarget;
            _behaviourTarget = behaviourTarget;
        }

        public void Enter() => throw new System.NotImplementedException();

        public void Update() => throw new System.NotImplementedException();

        public void Exit() => throw new System.NotImplementedException();
    }
}
