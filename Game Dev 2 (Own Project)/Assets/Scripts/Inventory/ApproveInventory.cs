using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproveInventory : MonoBehaviour {

	public void InventoryApproved()
    {
        FindObjectOfType<InventoryManager>().ApproveInventory();
    }
}
