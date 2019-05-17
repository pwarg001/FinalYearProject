using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2 : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    bool grounded = true; //check if player is on the ground

    bool doubleJump;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            doubleJump = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }



    void Update()
    {


        if (Input.GetButtonDown("Jump2") && grounded) //if player is on the ground they can jump
        {
            Jump();
        }
        else if (doubleJump && Input.GetButtonDown("Jump2")) // if double jump is allowed, player can jump one more time
        {
            Jump();
            doubleJump = false;
        }
    }


    void Jump()
    {
        GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;

    }
}
