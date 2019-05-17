using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlate1 : MonoBehaviour
{
    [SerializeField]
    private Animator PathController, PathController1, PathController2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PathController.SetBool("OpenPath", true);
            PathController1.SetBool("OpenPath", true);
            PathController2.SetBool("OpenPath", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PathController.SetBool("OpenPath", false);
            PathController1.SetBool("OpenPath", false);
            PathController2.SetBool("OpenPath", false);
        }
    }

}
