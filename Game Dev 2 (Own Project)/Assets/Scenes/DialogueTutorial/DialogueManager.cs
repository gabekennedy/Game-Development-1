using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {


   
    public Text nameText;
    public Text descriptionText;
    

    public Animator animator;

    private Queue<string> sentences;

    /*private static string dayNumberTimesTwo;
    public string dayNumber;
    public static int random = UnityEngine.Random.Range(1, 2);
    string randomTimesTwo = ((dayNumberTimesTwo) + random);
    */



    void Start () {
        sentences = new Queue<string>();

        //descriptionText.text = "Assignmnet 1";
         
}

public void StartDialogue (Dialogue dialogue)
    {
        
        //string text = sentences.Enqueue(dialogue.random);
        //promptText.text = text;
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;  
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();

        }

    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;

        }
        ///make note of these two lines becuase I'm pretty sure that how to use the "string text = promptText[(dayNumber * 2) + random]" part

        string sentence = sentences.Dequeue();
        descriptionText.text = sentence;

    }
	
   public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

}
