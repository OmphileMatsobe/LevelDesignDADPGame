using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsScript : MonoBehaviour
{
    [SerializeField]
    private Potions potion;

    [SerializeField]
    PotionsEffectScript effectScript;
    
    private enum Potions
    {
        Speed,
        lowGravity,
        Protection
    }

    


    private void OnCollisionEnter(Collision collision)
    {
      /*  Debug.Log("Collided");
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (potion)
            {
                case Potions.Speed:
                    
                    effectScript.SpeedPotion();
                    break;
                case Potions.lowGravity:

                    break;
                case Potions.Protection:

                    break;
            }
        }

        Destroy(gameObject); */
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            switch (potion)
            {
                case Potions.Speed:

                    effectScript.SpeedPotion();
                    break;
                case Potions.lowGravity:
                    effectScript.FloatPotion();
                    break;
                case Potions.Protection:
                    effectScript.ProtectionPotion();
                    break;
            }
        }
    }
}