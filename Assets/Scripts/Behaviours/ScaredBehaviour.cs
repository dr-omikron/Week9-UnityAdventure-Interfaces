using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class ScaredBehaviour : IBehaviour
    {
        private readonly Health _health;
        private readonly CharacterMover _characterMover;
        private readonly CharacterRotator _characterRotator;

        public ScaredBehaviour(Health health, CharacterMover characterMover, CharacterRotator characterRotator)
        {
            _health = health;
            _characterMover = characterMover;
            _characterRotator = characterRotator;
        }

        public void Enter()
        {
            _health.Kill();
            _characterMover.DisableMovement();
            _characterRotator.DisableRotations();
        }

        public void Update() {}

        public void Exit() {}
    }
}
