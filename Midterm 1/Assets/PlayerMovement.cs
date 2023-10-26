using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //variable for movement
    public float speed = 0.01f;
   

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -11)  //when A is pressed)
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);   //move left
        }

        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x <11) //when D is pressed
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y); //move right
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
