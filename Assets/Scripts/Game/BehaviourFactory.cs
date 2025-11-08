using Behaviours;
using Interfaces;
using Types;
using UnityEngine;

namespace Game
{
    public class BehaviourFactory
    {
        public IRestBehaviour GetEnemyRestBehaviour(RestBehaviourTypes spawnPointRestBehaviour)
        {
            switch (spawnPointRestBehaviour)
            {
                case RestBehaviourTypes.Idle:
                    return new IdleBehaviour();

                case RestBehaviourTypes.PatrolByPoints:
                    return new PointByPointPatrolBehaviour();

                case RestBehaviourTypes.PatrolByRandomDirection:
                    return new RandomDirectionPatrolBehaviour();

                default:
                    Debug.LogError("Unknown rest behaviour: " + spawnPointRestBehaviour);
                    return null;
            }
        }

        public IReactionBehaviour GetEnemyReactionBehaviour(ReactionBehaviourTypes spawnPointReactionBehaviour)
        {
            switch (spawnPointReactionBehaviour)
            {
                case ReactionBehaviourTypes.Persecution:
                    return new PersecutionBehaviour();
                
                case ReactionBehaviourTypes.RunningAway:
                    return new RunawayBehaviour();
                
                case ReactionBehaviourTypes.Scared:
                    return new ScaredBehaviour();
                
                default:
                    Debug.LogError("Unknown reaction behaviour: " + spawnPointReactionBehaviour);
                    return null;
            }
        }
    }
}
