using System.Collections.Generic;
using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class PointByPointPatrolBehaviour : IRestBehaviour
    {
        private readonly Queue<Vector3> _patrolPoints;
        private Character _character;

        /*public PointByPointPatrolBehaviour(List<Vector3> patrolPoints, Character character)
        {
            _patrolPoints = new Queue<Vector3>(patrolPoints);
            _character = character;
        }*/

        public void Resting()
        {
            
        }
    }
}
