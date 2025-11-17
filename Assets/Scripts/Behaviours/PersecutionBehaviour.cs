using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class PersecutionBehaviour : IBehaviour
    {
        private readonly Transform _persecutionTarget;
        private readonly CharacterMover _characterMover;
        private readonly CharacterRotator _characterRotator;

        public PersecutionBehaviour(Transform persecutionTarget, CharacterMover mover, CharacterRotator rotator)
        {
            _persecutionTarget = persecutionTarget;
            _characterMover = mover;
            _characterRotator = rotator;
        }

        public void Enter() { }

        public void Update()
        {
            Vector3 direction = (_persecutionTarget.position - _characterMover.transform.position).normalized;
            _characterMover.MoveTo(direction);
            _characterRotator.RotateTo(direction);
        }

        public void Exit() => _characterMover.MoveTo(Vector3.zero);
    }
}
