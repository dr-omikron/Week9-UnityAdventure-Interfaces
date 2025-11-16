using System.Collections.Generic;
using Behaviours;
using Characters;
using Interfaces;
using Types;
using UnityEngine;

namespace Game
{
    public class BehaviourDeterminer
    {
        public IBehaviour GetEnemyRestBehaviour(
            RestBehaviourTypes spawnPointRestBehaviour, 
            List<Vector3> patrolPoints, 
            CharacterMover mover, 
            CharacterRotator rotator)
        {
            switch (spawnPointRestBehaviour)
            {
                case RestBehaviourTypes.Idle:
                    return new IdleBehaviour();

                case RestBehaviourTypes.PatrolByPoints:
                    return new PointByPointPatrolBehaviour(patrolPoints, mover, rotator);

                case RestBehaviourTypes.PatrolByRandomDirection:
                    return new RandomDirectionPatrolBehaviour(mover, rotator);

                default:
                    Debug.LogError("Unknown rest behaviour: " + spawnPointRestBehaviour);
                    return null;
            }
        }

        public IBehaviour GetEnemyReactionBehaviour(
            ReactionBehaviourTypes spawnPointReactionBehaviour, 
            CharacterMover mover, 
            CharacterRotator rotator, 
            Health health, 
            Transform target)
        {
            switch (spawnPointReactionBehaviour)
            {
                case ReactionBehaviourTypes.Persecution:
                    return new PersecutionBehaviour(target, mover, rotator);
                
                case ReactionBehaviourTypes.RunningAway:
                    return new RunawayBehaviour(target, mover, rotator);
                
                case ReactionBehaviourTypes.Scared:
                    return new ScaredBehaviour(health);

                default:
                    Debug.LogError("Unknown reaction behaviour: " + spawnPointReactionBehaviour);
                    return null;
            }
        }
    }
}
