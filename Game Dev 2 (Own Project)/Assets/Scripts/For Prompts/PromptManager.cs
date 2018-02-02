using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptManager : MonoBehaviour {

    public List<Prompts> prompts;
    public static PromptManager manager;

	// Use this for initialization
	void Start () {
        prompts = new List<Prompts>();
        manager = this;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
