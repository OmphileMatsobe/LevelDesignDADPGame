using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDoor : MonoBehaviour
{

    [SerializeField]
    private GameObject door;

    [SerializeField]
    private float setDoorTimer, doorTimer;


    // Start is called before the first frame update
    void Start()
    {
        doorTimer = setDoorTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (door.activeSelf == false)
        {
            doorTimer -= Time.deltaTime;
        }

        if(doorTimer <= 0)
        {
            door.SetActive(true);
            doorTimer = setDoorTimer;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.SetActive(false);

        }


      
    }
}
