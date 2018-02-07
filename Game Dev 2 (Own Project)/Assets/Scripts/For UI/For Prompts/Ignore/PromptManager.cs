using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptManager : MonoBehaviour {

    public int random;
    GameManager gameManager;
   // public List<Prompts> prompts;
   // public static PromptManager manager = null;
    // public List<strings[]> = new List<strings[]>(); THIS WOULD HAVE BEEN USED HAD WE USED AN ARRAY FOR EACH DAY, AND AN ARRAY TO CALL EACH OF THESE DAYS

    string[] promptText = new string[10];
    
    

    /*
    private void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(this);
            manager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    */

    // Use this for initialization
    void Start () {

        gameManager = GetComponent<GameManager>();
        random = UnityEngine.Random.Range(0, 1);
        /*
        random = UnityEngine.Random.Range(1, 2);
        prompts = new List<Prompts>();
        manager = this;
        for (int counter = 0; counter < 1; counter++)
        {

            Prompts p = new Prompts("Order", 1, randomNumber);

            //prompts.Add(p);

            Debug.Log("Adding" + p.name);



        }
        */

        //define all your prompts per day
        promptText[0] = "Late Shipment";
        promptText[1] = "Contraband Shipment";
        promptText[2] = "Pirate Favour";
        promptText[3] = "Tight Schedule";
        promptText[4] = "Night Shift";
        promptText[5] = "Radio Interference";
        promptText[6] = "Late Shipment";
        promptText[7] = "Contraband Shipment";
        promptText[8] = "Pirate Favour";
        promptText[9] = "Tight Schedule";
        
        

        //  dailyPromptText.Add(promptTextDay1);


        

        

        //string text = dailyPromptText[0][1];

    }

    public void startDialogue()
    {
        //we need to actually show this text on the screen 
        Debug.Log("Receiving Order" + promptText[0]);
        string text = promptText[(gameManager.dayNumber * 2) + random];
        //promptText.text = text;
    }

    /// <summary>
    /// Making each unique prompt bubble
    /// </summary> 
    /// NO LONGER NECESSARY, NO LONGER USING LISTS
    /*
    Prompts contraShipment = new Prompts("Order", 1, 1);
    Prompts lateShipment = new Prompts("Order", 1, 2);
    */ 
    
    void Update () {



        startDialogue();
       
       


        /*foreach(string prompt in promptText)
        {

            Debug.Log(prompt);
        }*/
      
	}


   


}
