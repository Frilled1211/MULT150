using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") / 10;
        float mY = Input.GetAxis("Mouse Y") / 10;

        float moveX = mX * moveSpeed * Time.deltaTime;
        float moveY = mY * moveSpeed * Time.deltaTime;


        transform.Translate(moveX, moveY, 0, Space.World);
    }
}
