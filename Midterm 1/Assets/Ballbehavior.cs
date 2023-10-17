using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballbehavior : MonoBehaviour
{
    public float speed;
    private float Move;

   

    //variables
    private Vector2 direction; //control direction of movement
    public bool goingUp;
    public bool goingDown;
    public bool goingLeft;
    public bool goingRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) != true)   //when W key is pressed
        {
            direction = Vector2.left;        //go left
            goingLeft = true;
        }




           

        
    }
}
