using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

    [SerializeField]
    private List<Transform> Waypoints;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private int TargetPos;




    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[TargetPos].position, moveSpeed * Time.deltaTime);

        if (transform.position == Waypoints[TargetPos].position)
        {
            TargetPos += 1;
        }

        if (TargetPos == Waypoints.Count)
        {
            TargetPos = 0;
        }
    }
}
