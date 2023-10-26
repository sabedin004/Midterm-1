using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireMove : MonoBehaviour
{
    //variable for speed
   
    public float ySpeed = 0; // Variable for y speed

    //variable for borders

    private float yBorder = 6.5f; //variavle for verticle border


    // Start is called before the first frame update
    void Start()
    {

        ySpeed = 0.05f;//declare value for verticle speed
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

    //Funtion for collision
    void OnTriggerEnter2D(Collider2D other)
    {
     
        if (other.tag == "Obstacle")      //check if the other object is an obstacle
        {
            //Debug.Log("Hit")
            SceneManager.LoadScene("SampleScene");                //change to end scene
        }

    }
}
