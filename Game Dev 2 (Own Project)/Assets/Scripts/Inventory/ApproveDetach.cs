using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// I NO LONGER NEED THIS WHACKY IDEA OF A SCRIPT EITHER
/// </summary>

public class ApproveDetach : MonoBehaviour {

    private GeneratedInventory generatedInventory;
    InventoryManager inventoryManager;

	void Start () {

        generatedInventory = gameObject.GetComponentInParent<GeneratedInventory>();

	}
	
	
	void Update () {
		
	}
}
