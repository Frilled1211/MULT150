using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

        
        float health = 1004f;
        
        {
            Debug.Log("player is alive");
        
           
         float posionDamage = 125.5f;

        posionDamage = health - 125.5f;

    
        Debug.Log("health is " + health);
        //Debug.Log("you have taken posion damage " + posionDamage);


       // float posionDamage = 125.5f;

        posionDamage = health - 251f;


       // Debug.Log("health is " + health);
        Debug.Log("you have taken posion damage hp is now at " + posionDamage);


       // float posionDamage = 125.5f;

        posionDamage = health - 376.5f;


       // Debug.Log("health is " + health);
        Debug.Log("you have taken posion damage hp is now at " + posionDamage);
       
        
        // float posionDamage = 125.5f;

        posionDamage = health - 502f;


        // Debug.Log("health is " + health);
        Debug.Log("you have taken posion damage hp is now at " + posionDamage);

        // float posionDamage = 125.5f;

        posionDamage = health - 627.2f;


        // Debug.Log("health is " + health);
        Debug.Log("you have taken posion damage hp is now at " + posionDamage);

        // float posionDamage = 125.5f;

        posionDamage = health - 753f;


                // Debug.Log("health is " + health);
             Debug.Log("Danger!!! Low health " + posionDamage);

              // float posionDamage = 125.5f;

                posionDamage = health - 878.5f;


                // Debug.Log("health is " + health);
            Debug.Log("you have taken posion damage hp is now at " + posionDamage);
    
                // float posionDamage = 125.5f;

             posionDamage = health - 1004f;

              Debug.Log("health is now at 0");
            Debug.Log("You have been unalived");


        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
