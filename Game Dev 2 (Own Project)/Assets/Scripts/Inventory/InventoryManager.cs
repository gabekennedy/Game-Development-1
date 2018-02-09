using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
    public int choiceMeter;
    public Image meterImage;
    public Text inventoryExpected;
    public Text inventoryExpectedTwo;
    public Text inventoryGenerated;
    public Text inventoryGeneratedTwo;
    public Text approveButtonText;
    public Animator approveButtonAnimator;
    public Animator approvedInventoryAnimator;
    string[] expectedInventory = new string[2];
    string[] generatedInventory = new string[4];
    //Image[] meterImages = new Image[6];

    public Sprite[] images = new Sprite[6];

    bool approveIsAttached = true;
    
    //public string[] mismatchingInventory = new string[2]; Before I had matching/mismatching,
    //now just one array of length of 4 whose range will be split up, the first half
    //will correspond to matching, the second to mismatching items
    RangeInt rangeArray;
    
    //public int arrayMatch;
    //public int arrayMismatch;
    public int randomRange;

	void Start () {
        meterImage.sprite = images[0];

        randomRange = UnityEngine.Random.Range(0, 3);
       
        expectedInventory[0] = "Alkaline";
        expectedInventory[1] = "Fluoride";

        generatedInventory[0] = "Alkaline";
        generatedInventory[1] = "Fluoride";
        generatedInventory[2] = "Nuke";
        generatedInventory[3] = "Cyanide";

        inventoryExpected.text = expectedInventory[0];
        inventoryExpectedTwo.text = expectedInventory[1];

        if (randomRange == 0)
        {
            rangeArray.start = 0;
            rangeArray.length = 2;
            
        }

        else
        {
            rangeArray.start = 2;
            rangeArray.length = 2;
        }
        inventoryGenerated.text = generatedInventory[rangeArray.start];
        inventoryGeneratedTwo.text = generatedInventory[rangeArray.start + 1];
	}
	
	
	void Update () {
       
	}

    public void ApproveInventory()
    {
        approveButtonAnimator.SetBool("IsApproved", true);
        approveIsAttached = false;
        approveButtonText.color = new Color(0, 2, 0);
        inventoryGenerated.color = new Color(0, 15, 0);
        inventoryGeneratedTwo.color = new Color(0, 15, 0);
    }
}
