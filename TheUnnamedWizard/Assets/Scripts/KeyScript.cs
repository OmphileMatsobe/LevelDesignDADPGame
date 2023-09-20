using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{


    DogPathScript pathScript;

    // Start is called before the first frame update
    void Start()
    {
       pathScript = GameObject.FindGameObjectWithTag("PathToDog").GetComponent<DogPathScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Player"))
        {
            pathScript.CollectedKey();

            Destroy(gameObject);
        }
       
    }
}
