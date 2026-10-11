using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float posionDamage = 125.5f;
       
        
        if (health >= 1004f)
        {
            Debug.Log("You are alive");
        }
         
       
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
        Debug.Log(health -= posionDamage);
       
        if (health <= 0)
        {
            Debug.Log("You have died!!");
        }
        
          
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
