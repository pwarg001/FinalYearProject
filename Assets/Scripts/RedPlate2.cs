using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlate2 : MonoBehaviour
{
    [SerializeField]
    private Animator PathController3, PathController4, PathController5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PathController3.SetBool("OpenPath", true);
            PathController4.SetBool("OpenPath", true);
            PathController5.SetBool("OpenPath", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PathController3.SetBool("OpenPath", false);
            PathController4.SetBool("OpenPath", false);
            PathController5.SetBool("OpenPath", false);
        }
    }

}
