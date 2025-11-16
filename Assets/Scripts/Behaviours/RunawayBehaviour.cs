using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class RunawayBehaviour : IBehaviour
    {
        private readonly Transform _runawayTarget;
        private readonly CharacterMover _characterMover;
        private readonly CharacterRotator _characterRotator;

        public RunawayBehaviour(Transform runawayTarget, CharacterMover mover,  CharacterRotator rotator)
        {
            _runawayTarget = runawayTarget;
            _characterMover = mover;
            _characterRotator = rotator;
        }

        public void Enter() { }

        public void Update()
        {
            Vector3 direction = (_characterMover.transform.position - _runawayTarget.position).normalized;

            _characterMover.MoveTo(direction);
            _characterRotator.RotateTo(direction);
        }

        public void Exit() { }
    }
}
