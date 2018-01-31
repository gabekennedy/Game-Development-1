using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour {

    SpriteRenderer myRocket;

    Rigidbody2D rocketBody;

    public int counter;

    public bool RocketUp = false;
    float speed = 0.5f;
    float accel = 2f;
   
    // Use this for initialization
    void Start () {

       myRocket = GetComponent<SpriteRenderer>();

        rocketBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space) )
        {
            
            rocketBody.velocity = new Vector2(0, speed);
            RocketUp = true;
        }

       

        if (RocketUp == true)
        {
            //accel system based on counter acting as multiplier of speed
            counter++;

            if (Input.GetKeyDown(KeyCode.F))
            {

                //(this caused the rocket to slow down on one press, and to stop after two presses)
                //rocketBody.velocity = rocketBody.velocity * accel * Time.deltaTime;
                
                rocketBody.velocity = new Vector2(0, speed * accel * counter/9*Time.deltaTime );

            }
            


        }



    }
}
