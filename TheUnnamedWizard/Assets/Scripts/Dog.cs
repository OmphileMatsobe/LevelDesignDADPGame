using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    [SerializeField]
    private GameObject VictoryDisplay;
    
    
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            VictoryDisplay.SetActive(true);
        }
    }
}
