using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptManager : MonoBehaviour {

    public List<Prompts> prompts;
    public static PromptManager manager;
    public int randomNumber;

    string[] dailyPromptText = new string[2];
    dailyPromptText[0] = "day one prompt one";
    dailyPromptText[1] = "day one prompt two";

    // Use this for initialization
    void Start () {

        randomNumber = UnityEngine.Random.Range(1, 2);
        prompts = new List<Prompts>();
        manager = this;
        for (int counter = 0; counter < 1; counter++)
        {

            Prompts p = new Prompts("Order", 1, randomNumber);

            //prompts.Add(p);

            Debug.Log("Adding" + p.name);



        }
    }


    /// <summary>
    /// Making each unique prompt bubble
    /// </summary>
    Prompts contraShipment = new Prompts("Order", 1, 1);
    Prompts lateShipment = new Prompts("Order", 1, 2);

    // Update is called once per frame
    void Update () {
		
      
	}
}
