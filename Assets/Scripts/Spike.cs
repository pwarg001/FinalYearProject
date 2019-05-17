using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float rotationSpeed = 2500f;

    void Update()
    {
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}
