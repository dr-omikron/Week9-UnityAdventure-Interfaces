using Characters;
using Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Behaviours
{
    public class RandomDirectionPatrolBehaviour : IBehaviour
    {
        private const float TimeToChangeDirection = 1f; 

        private readonly CharacterMover _characterMover;
        private readonly CharacterRotator _characterRotator;
        private Vector3 _direction;
        private float _timer;

        public RandomDirectionPatrolBehaviour(CharacterMover mover,  CharacterRotator rotator)
        {
            _characterMover = mover;
            _characterRotator = rotator;

            SetRandomDirection();
        }

        public void Enter()
        {
            SetRandomDirection();
        }

        public void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= TimeToChangeDirection)
            {
                SetRandomDirection();
                ResetTimer();
            }

            _characterMover.MoveTo(_direction.normalized);
            _characterRotator.RotateTo(_direction.normalized);
        }

        public void Exit()
        {
            ResetTimer();
        }

        private void SetRandomDirection()
        {
            Vector2 randomDirection = Random.insideUnitCircle;
            _direction = new Vector3(randomDirection.x, 0, randomDirection.y);
        }

        private void ResetTimer() => _timer = 0;
    }
}
