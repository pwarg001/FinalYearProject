using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            GetComponent<Animator>().SetTrigger("ElevatorTrigger");
        }
    }

}
