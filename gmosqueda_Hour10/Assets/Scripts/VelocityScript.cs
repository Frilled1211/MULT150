using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class VelocityScript : MonoBehaviour
{
    public float max = 50f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
        rb.velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));
    }

    // Update is called once per frame
    void Update()
    {

    }
}