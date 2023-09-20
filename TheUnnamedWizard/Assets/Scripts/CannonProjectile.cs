using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonProjectile : MonoBehaviour
{
    [SerializeField] GameObject cannonProjectile, spawn;
    [SerializeField] Transform cannonTra;
    bool enableShot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void cannonShot()
    {
        GameObject cannon;

        cannon = Instantiate(cannonProjectile, spawn.transform.position, transform.rotation);

        /*
         * Use Quaternion to get the direction of the bullet/shot
         */
        cannon.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 5);
        enableShot = false;
    }

    IEnumerator enableShotIE()
    {
        yield return new WaitForSeconds(2f);
        enableShot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableShot)
        {
            cannonShot();
            StartCoroutine(enableShotIE());
        }
    }
}
