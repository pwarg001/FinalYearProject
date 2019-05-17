using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbineControl : MonoBehaviour
{
    public Blade blade;

    void OnTriggerEnter(Collider other)
    {
        blade.rotationSpeed -= 900;
    }

    void OnTriggerExit(Collider other)
    {
        blade.rotationSpeed += 1000;
    }

}
