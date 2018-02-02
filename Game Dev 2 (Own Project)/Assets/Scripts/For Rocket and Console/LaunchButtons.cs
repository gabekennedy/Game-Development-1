using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchButtons : MonoBehaviour
{


    

   public bool RocketUp = false;

    public GameObject Rocket;

    

    // Use this for initialization
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            RocketUp = true;
            GameObject newRocket = Instantiate(Rocket);
            newRocket.transform.position = new Vector3(-4, -4, 0);

            


        }

       

    }
}
