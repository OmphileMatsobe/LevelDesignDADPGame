using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPathScript : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> Platforms;

    [SerializeField]
    private List<GameObject> displayPlatforms;

   


    private void Start()
    {
        foreach (GameObject deactivatePlatform in Platforms)
        {
            deactivatePlatform.SetActive(false);
        }
    }

    public void CollectedKey()
    {
        GameObject DeactivateDisplay = displayPlatforms[0];
        GameObject ActivatePlatform = Platforms[0];

        displayPlatforms.Remove(DeactivateDisplay);
        DeactivateDisplay.SetActive(false);

        Platforms.Remove(ActivatePlatform);
        ActivatePlatform.SetActive(true);
    }
}
