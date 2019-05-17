using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

    public float rotationSpeed = 2500f;

    void Update()
{
    transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
}

    

}

