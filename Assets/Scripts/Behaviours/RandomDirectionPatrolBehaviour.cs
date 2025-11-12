using Characters;
using Interfaces;
using UnityEngine;

namespace Behaviours
{
    public class RandomDirectionPatrolBehaviour : IBehaviour
    {
        private readonly CharacterMover _characterMover;

        public RandomDirectionPatrolBehaviour(Character behaviourTarget)
        {
            _characterMover = behaviourTarget.GetComponent<CharacterMover>();

            if(_characterMover == null)
                Debug.LogWarning("[RandomDirectionPatrolBehaviour] CharacterMover component is missing from target.");
        }

        public void Enter() => throw new System.NotImplementedException();

        public void Update() => throw new System.NotImplementedException();

        public void Exit() => throw new System.NotImplementedException();
    }
}
