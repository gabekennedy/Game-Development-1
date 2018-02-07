using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromptManager2 : MonoBehaviour {

    string text;
    public Text nameText;
    public Text descriptionText;


   
    public int dayNumber;
    public int random;
    private int randomTimesDay;
    string[] promptText = new string[10];

    // Use this for initialization
    void Start () {

        dayNumber = UnityEngine.Random.Range(0, 3);
        random = UnityEngine.Random.Range(1, 2);
        randomTimesDay = random * dayNumber;

        //string text = promptText[(dayNumber * 2) + random];

        //descriptionText.text = text;

        promptText[0] = "Late Shipment";
        promptText[1] = "Contraband Shipment";
        promptText[2] = "Pirate Favour";
        promptText[3] = "Overseer Favour";
        promptText[4] = "Night Shift";
        promptText[5] = "Radio Interference";
        promptText[6] = "Late Shipment";
        promptText[7] = "Contraband Shipment";
        promptText[8] = "Pirate Favour";
        promptText[9] = "Tight Schedule";

        descriptionText.text = promptText[randomTimesDay];
       
        
    }

    /*// Update is called once per frame
    void Update () {

        Debug.Log(promptText[randomTimesDay]);

        descriptionText.text = text;


    }*/
    

    
    

}
