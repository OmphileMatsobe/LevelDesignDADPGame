using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoints : MonoBehaviour
{
    public Transform GetWaypoint(int waypointIndex)
    {
        return transform.GetChild(waypointIndex);
    }

    public int GetNextWaypointIndex(int currentWaypointIndex)
    {
        int nextWayPointIndex = currentWaypointIndex + 1;

        if (nextWayPointIndex == transform.childCount)
        {
            nextWayPointIndex = 0;
        }

        return nextWayPointIndex;
    }
}
