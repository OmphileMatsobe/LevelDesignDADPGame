using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float characterSpeed, runSpeed, rotationSpeed, jumpSpeed;
    [SerializeField] protected Transform cameraTransform;
    CharacterController characterController;
    Vector3 playerMove, moveDirection;
    float setSpeed;
    public bool enableRun, enableJump;
    int jumpCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        enableRun = enableJump = false;
    }

    void Jump()
    {
        this.gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, 200, 0);
    }

    void Run()
    {

    }

    void Attack()
    {

    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
            Cursor.lockState = CursorLockMode.Locked;
        else
            Cursor.lockState = CursorLockMode.None;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain" || collision.gameObject.tag == "Platform")
        {
            Debug.Log("Is On Ground");
            enableJump = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain" || collision.gameObject.tag == "Platform")
        {
            Debug.Log("Is Off Ground");
            enableJump = false;
        }
    }

    IEnumerator waitForDouble()
    {
        yield return new WaitForSeconds(0.2f);
        jumpCount++;
        enableJump = true;
    }

    private void FixedUpdate()
    {

        if (enableRun)
            setSpeed = runSpeed;
        else
            setSpeed = characterSpeed;

        playerMove.x = Input.GetAxis("Horizontal");
        playerMove.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Mouse0))
            setSpeed = setSpeed / 5;
        

        playerMove.Normalize();

        playerMove = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * playerMove;

        this.gameObject.GetComponent<Rigidbody>().velocity = playerMove * setSpeed;
        this.gameObject.GetComponent<Rigidbody>().velocity += (Physics.gravity) / 3f;

        if (playerMove != Vector3.zero)
        {
            Quaternion characterRotation = Quaternion.LookRotation(playerMove, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation ,characterRotation, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (enableJump == true && jumpCount < 2)
            {
                Debug.Log("Jump" + jumpCount);
                Jump();
                enableJump = false;
                StartCoroutine("waitForDouble");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.LeftShift))
            enableRun = true;
        else
            enableRun = false;*/
        
    }
}
