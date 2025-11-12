using Characters;
using Interfaces;

namespace Behaviours
{
    public class PersecutionBehaviour : IBehaviour
    {
        private readonly Character _persecutionTarget;
        private readonly Character _behaviourTarget;

        public PersecutionBehaviour(Character behaviourTarget, Character persecutionTarget)
        {
            _persecutionTarget = persecutionTarget;
            _behaviourTarget = behaviourTarget;
        }

        public void Enter() => throw new System.NotImplementedException();

        public void Update() => throw new System.NotImplementedException();

        public void Exit() => throw new System.NotImplementedException();
    }
}
