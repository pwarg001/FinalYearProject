using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTrigger3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            GetComponent<Animator>().SetTrigger("ElevatorTrigger3");
        }
    }
}
