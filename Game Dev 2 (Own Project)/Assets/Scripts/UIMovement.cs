using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour
{
     
     RectTransform canvas;
     RectTransform button;
     Vector3 startingPosition;
     public float speed;

     // Use this for initialization
     void Start () {
         
         canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
         button = gameObject.GetComponent<RectTransform>();
         speed = 5f;
     }

     // Update is called once per frame
     void Update () {


         transform.Translate(speed, 0, 0);

         if (Input.GetKeyDown(KeyCode.Space))
         {
            canvas.position = new Vector2(transform.position.x+5, transform.position.y)*Time.deltaTime;

         }         

     }

   
 } 
 

   /* RectTransform canvas;
    RectTransform button;
    Vector3 startingPosition;
    public float speed;

    void Start()
    {
        button = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startingPosition = transform.position;
        speed = -10f;
    }

    void Update()
    {
        transform.Translate(0f, speed, 0f);
        if (button.position.y < -button.rect.height)
            transform.position = new Vector3(startingPosition.x, canvas.rect.height + button.rect.height, startingPosition.z);
    }*/


  
