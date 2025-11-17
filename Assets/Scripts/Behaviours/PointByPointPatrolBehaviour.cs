using System.Collections.Generic;
using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class PointByPointPatrolBehaviour : IBehaviour
    {
        private const float MinDistance = 0.05f;

        private readonly Queue<Vector3> _patrolPoints;
        private readonly CharacterMover _characterMover;
        private readonly CharacterRotator _characterRotator;
        private Vector3 _currentPoint;

        public PointByPointPatrolBehaviour(List<Vector3> patrolPoints, CharacterMover mover, CharacterRotator rotator)
        {
            _patrolPoints = new Queue<Vector3>(patrolPoints);
            _characterMover = mover;
            _characterRotator = rotator;

            _currentPoint = GetNewPatrolPoint();
        }

        public void Enter()
        {
            _currentPoint = GetNewPatrolPoint();
        }

        public void Update()
        {
            Vector3 directionToPoint = _currentPoint - _characterMover.transform.position;
            Vector3 movingDirection = new Vector3(directionToPoint.x, 0, directionToPoint.z); 

            if (movingDirection.magnitude < MinDistance)
            {
                _currentPoint = GetNewPatrolPoint();
            }

            _characterMover.MoveTo(movingDirection.normalized);
            _characterRotator.RotateTo(movingDirection.normalized);
        }

        public void Exit() {}

        private Vector3 GetNewPatrolPoint()
        {
            Vector3 patrolPoint = _patrolPoints.Dequeue();
            _patrolPoints.Enqueue(patrolPoint);
            return patrolPoint;
        }
    }
}
