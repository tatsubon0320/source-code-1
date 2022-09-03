using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    
    void FixedUpdate()
    {
   
        float x = Input.GetAxis("Horizontal");

 
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

      
        Vector2 force = new Vector2(x * 10, 0);

   
        rb.AddForce(force);

    }

}
