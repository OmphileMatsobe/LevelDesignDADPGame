using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform beginPos, endPos;
    

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private bool canMove = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = beginPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, moveSpeed * Time.deltaTime);
        }
       
        if (transform.position == endPos.position)
        {
            transform.position = beginPos.position;
        }
    }
}
