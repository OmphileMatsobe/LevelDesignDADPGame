using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsEffectScript : MonoBehaviour
{
    [SerializeField]
    PlayerMovement playerMovement;

    [Header("Sprinting")]
    [SerializeField]
    private float setSpeedTimer, speedTimer;

    [SerializeField]
    private bool isSprinting = false;

    [Header("Floating")]
    [SerializeField]
    private float setFloatTimer, floatTimer;

    [SerializeField]
    private bool isFloating = false;

    [Header("Protection")]
    [SerializeField]
    private float setProtectionTimer, protectionTimer;

    [SerializeField]
    public bool isProtected = false;


    private void Start()
    {
        speedTimer = setSpeedTimer;
    }




    public void SpeedPotion()
    {

        speedTimer = setSpeedTimer;
        playerMovement.enableRun = true;
        isSprinting = true;

    }

    public void FloatPotion()
    {
        isFloating = true;
       
    }

    public void ProtectionPotion()
    {
        isProtected = true;
       
    }

    private void Update()
    {
        if (isSprinting == true)
        {
            speedTimer -= Time.deltaTime;
            if (speedTimer <= 0)
            {
                isSprinting = false;
                playerMovement.enableRun = false;
                
            }
        }

        if (isFloating == true)
        {
            floatTimer -= Time.deltaTime;
            if(floatTimer <= 0)
            {
                isFloating = true;
                floatTimer = setFloatTimer;
            }
        }

        if (isProtected == true)
        {
            protectionTimer -= Time.deltaTime;
            if(protectionTimer <= 0)
            {
                isProtected = true;
                protectionTimer = setProtectionTimer;
            }
        }
    }

}
