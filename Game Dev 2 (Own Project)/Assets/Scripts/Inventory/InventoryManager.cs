using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public Text inventoryExpected;
    public Text inventoryGenerated;
    public Text textArrayTextOne;
    public Text textArrayTextTwo;
    string[] expectedInventory = new string[2];
    string[] generatedInventory = new string[4];
    public string[] textArray = new string[2];
    //public string[] mismatchingInventory = new string[2]; Before I had matching/mismatching,
    //now just one array of length of 4 whose range will be split up, the first half
    //will correspond to matching, the second to mismatching items
    //RangeInt rangeArray;
    
    //public int arrayMatch;
    //public int arrayMismatch;
    public int randomRange;

	void Start () {

        randomRange = UnityEngine.Random.Range(0, 3);

        expectedInventory[0] = "Alkaline";
        expectedInventory[1] = "Fluoride";

        generatedInventory[0] = "Alkaline";
        generatedInventory[1] = "Fluoride";
        generatedInventory[2] = "Nuke";
        generatedInventory[3] = "Cyanide";



        /*if (randomRange == 0)
        {
            rangeArray.start = 0;
            rangeArray.length = 2;
        }

        else
        {
            rangeArray.start = 2;
            rangeArray.length = 2;
        }*/

        inventoryGenerated.text = generatedInventory[randomRange];

	}
	
	
	void Update () {
       
	}
}
