using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject playerProjectile, cannonProjectile, spawn;
    [SerializeField] Transform playerTransform;
    [SerializeField] float shotPower;
    [SerializeField] TMP_Text potionTxt;
    [SerializeField] Image img;
    public int potionCount = 0;




    Vector3 shotMove = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator delaySpell()
    {
        yield return new WaitForSeconds(2f);
    }

    void shot()
    {
        GameObject projectile;

        projectile = Instantiate(playerProjectile, spawn.transform.position, transform.rotation);

        /*
         * Use Quaternion to get the direction of the bullet/shot
         */

        Debug.Log(playerTransform.rotation.eulerAngles.y);
        projectile.GetComponent<Rigidbody>().velocity = playerTransform.forward * 50;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            shot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        potionTxt.text = ": " + potionCount.ToString();
    }
}