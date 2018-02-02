using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompts  {

    public string name;
    public float dayNumber;
    public float promptNumber;
   // public float randomNumber = UnityEngine.Random.Range(1, 2);

    public Prompts(string name, float dayNumber, float promptNumber)
    {

        this.name = name;
        this.dayNumber = dayNumber;
        this.promptNumber = promptNumber;

    }

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
