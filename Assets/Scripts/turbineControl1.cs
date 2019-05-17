using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbineControl1 : MonoBehaviour
{
    public Blade1 blade1;

    void OnTriggerEnter(Collider other)
    {
        blade1.rotationSpeed -= 900;
    }

    void OnTriggerExit(Collider other)
    {
        blade1.rotationSpeed += 1000;
    }
}
