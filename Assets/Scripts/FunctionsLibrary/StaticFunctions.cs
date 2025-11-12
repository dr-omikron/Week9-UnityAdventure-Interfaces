using System.Collections.Generic;
using UnityEngine;

namespace FunctionsLibrary
{
    public static class StaticFunctions
    {
        public static List<Vector3> GetPositionsFromTransforms(List<Transform> transforms)
        {
            List<Vector3> patrolPointsPositions = new List<Vector3>();

            foreach (Transform t in transforms)
                patrolPointsPositions.Add(t.position);

            return patrolPointsPositions;
        }
    }
}
