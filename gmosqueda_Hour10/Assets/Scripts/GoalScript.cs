using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private bool isSolved = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == tag)
        {
            
            isSolved = true;

            
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
            }

            Destroy(other.gameObject);
        }
    }

    public bool IsSolved()
    {
       
        return isSolved;
    }
}