using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    [SerializeField]
    private int PlayerHealth;

    [SerializeField]
    PotionsEffectScript effectScript;

    [SerializeField]
    public Transform RespawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth == 0)
        {
            //EndGame
        }
    }

    public void DamagePlayer()
    {
       
        
            PlayerHealth -= 1;
            transform.position = RespawnPoint.position;
        
    }


    private void Start()
    {
        RespawnPoint.position = transform.position;
    }
}
