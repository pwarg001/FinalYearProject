using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2controller : MonoBehaviour
{
    public float moveSpeed = 10;
    private Rigidbody rb;

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
        float hAxis = Input.GetAxis("Horizontal2");
        float vAxis = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * moveSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump2"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "DeathZone")
        {
            transform.position = respawnPoint;
        }
        if (coll.tag == "Checkpoint2")
        {
            respawnPoint = coll.transform.position;
        }
    }
}
