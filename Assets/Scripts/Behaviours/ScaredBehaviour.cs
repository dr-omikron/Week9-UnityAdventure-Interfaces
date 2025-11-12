using Characters;
using Interfaces;

namespace Behaviours
{
    public class ScaredBehaviour : IBehaviour
    {
        private readonly Character _scaringTarget;
        private readonly Character _behaviourTarget;

        public ScaredBehaviour(Character scaringTarget, Character behaviourTarget)
        {
            _scaringTarget = scaringTarget;
            _behaviourTarget = behaviourTarget;
        }

        public void Enter() => throw new System.NotImplementedException();

        public void Update() => throw new System.NotImplementedException();

        public void Exit() => throw new System.NotImplementedException();
    }
}
