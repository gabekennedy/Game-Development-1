using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompter : MonoBehaviour {

    public int speed = 5000;
    
    Rigidbody2D bubbleBody;


	// Use this for initialization
	void Start () {

        bubbleBody = GetComponent<Rigidbody2D>();


	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Space))

        {


            
        }

        
           

	}
}
