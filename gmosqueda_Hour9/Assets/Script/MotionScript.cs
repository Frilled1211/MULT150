using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.name == "Sphere")
        {
            Debug.Log("Sphere entered " + gameObject.name);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.name == "Sphere")
        {
            Debug.Log("Sphere is staying in " + gameObject.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || other.name == "Sphere")
        {
            Debug.Log("Sphere exited " + gameObject.name);
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
