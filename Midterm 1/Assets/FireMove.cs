using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMove : MonoBehaviour
{
    //variable for speed
   
    public float ySpeed = 0; // Variable for y speed

    //variable for borders
   
    private float yBorder = 4.5f; //variavle for verticle border


    // Start is called before the first frame update
    void Start()
    {
      
        ySpeed = 0.0125f; //declare value for verticle speed
    }

    // Update is called once per frame
    void Update()
    {
    

        //verticle movement 
        transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        if (transform.position.y >= yBorder)
        {
            ySpeed *= -1;
        }
        if (transform.position.y <= -yBorder)
        {
            ySpeed *= -1;
        }

    }
}
