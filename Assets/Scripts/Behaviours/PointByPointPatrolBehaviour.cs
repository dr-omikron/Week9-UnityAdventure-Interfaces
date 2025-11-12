using System.Collections.Generic;
using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class PointByPointPatrolBehaviour : IBehaviour
    {
        private readonly Queue<Vector3> _patrolPoints;
        private readonly CharacterMover _characterMover;

        public PointByPointPatrolBehaviour(List<Vector3> patrolPoints, Character behaviourTarget)
        {
            _patrolPoints = new Queue<Vector3>(patrolPoints);
            _characterMover = behaviourTarget.GetComponent<CharacterMover>();

            if(_characterMover == null)
                Debug.LogWarning("[PointByPointPatrolBehaviour] CharacterMover component is missing from target.");
        }

        public void Enter() => throw new System.NotImplementedException();

        public void Update() => throw new System.NotImplementedException();

        public void Exit() => throw new System.NotImplementedException();
    }
}
