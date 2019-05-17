using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    public bool checkPointReached;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rend.sharedMaterial = material[1];
            checkPointReached = true;
        }
    }
}
