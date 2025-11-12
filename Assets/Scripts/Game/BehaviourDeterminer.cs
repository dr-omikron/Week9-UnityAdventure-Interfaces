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
        public IBehaviour GetEnemyRestBehaviour(RestBehaviourTypes spawnPointRestBehaviour, List<Vector3> patrolPoints, Character behaviourTarget)
        {
            switch (spawnPointRestBehaviour)
            {
                case RestBehaviourTypes.Idle:
                    return new IdleBehaviour();

                case RestBehaviourTypes.PatrolByPoints:
                    return new PointByPointPatrolBehaviour(patrolPoints, behaviourTarget);

                case RestBehaviourTypes.PatrolByRandomDirection:
                    return new RandomDirectionPatrolBehaviour(behaviourTarget);

                default:
                    Debug.LogError("Unknown rest behaviour: " + spawnPointRestBehaviour);
                    return null;
            }
        }

        public IBehaviour GetEnemyReactionBehaviour(ReactionBehaviourTypes spawnPointReactionBehaviour, Character behaviourTarget, Character reactionTarget)
        {
            switch (spawnPointReactionBehaviour)
            {
                case ReactionBehaviourTypes.Persecution:
                    return new PersecutionBehaviour(behaviourTarget, reactionTarget);
                
                case ReactionBehaviourTypes.RunningAway:
                    return new RunawayBehaviour(behaviourTarget, reactionTarget);
                
                case ReactionBehaviourTypes.Scared:
                    return new ScaredBehaviour(behaviourTarget, reactionTarget);
                
                default:
                    Debug.LogError("Unknown reaction behaviour: " + spawnPointReactionBehaviour);
                    return null;
            }
        }
    }
}
