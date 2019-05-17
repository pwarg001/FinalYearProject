using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCube : MonoBehaviour
{
    public float pushPower = 5.0f;
     
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody; //check if object has rigibody attached
        if (body == null || body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y < -0.3f)
        {
            return;
        }

        

        Vector3 direction = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = direction * pushPower;

    }


}
