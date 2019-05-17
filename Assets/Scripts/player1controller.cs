using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1controller : MonoBehaviour
{
    public float moveSpeed = 10;
    private Rigidbody rb;

    public bool onBeltArea = false;
    public GameObject beltZone;

    bool grounded = true;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public Vector3 respawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * moveSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if (onBeltArea) {
            rb.AddForce(beltZone.GetComponent<BeltArea>().direction * beltZone.GetComponent<BeltArea>().strength);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Belt") {
            beltZone = coll.gameObject;
            onBeltArea = true;
        }
        if (coll.tag == "DeathZone")
        {
            transform.position = respawnPoint;
        }
        if (coll.tag == "Checkpoint")
        {
            respawnPoint = coll.transform.position;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Belt")
        {
            beltZone = coll.gameObject;
            onBeltArea = false;
        }
    }

}
