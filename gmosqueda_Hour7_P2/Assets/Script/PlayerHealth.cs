using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        if (health >= 1004f)
        {
            Debug.Log("you are alive");
        }

        while (health <= 0)
        {
            health -= poisonDamage;
        }

       

        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);
        Debug.Log(health -= poisonDamage);

        if (health <= 0)
        {
            Debug.Log("you are dead!!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
