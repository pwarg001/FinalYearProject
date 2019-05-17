using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbineControl2 : MonoBehaviour
{
    public Blade2 blade2;

    void OnTriggerEnter(Collider other)
    {
        blade2.rotationSpeed -= 900;
    }

    void OnTriggerExit(Collider other)
    {
        blade2.rotationSpeed += 1000;
    }
}
