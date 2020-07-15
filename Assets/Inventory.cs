using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public Player player;
    public List<Item> items = new List<Item>();
    string ObjectName;
    int InventorySpace;

    // Use this for initialization
    void Start () {
        player = GetComponentInParent<Player>();
        //InventorySpace = ObtainedItems.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddToInventory()
    {
        for (int i = 0; i < InventorySpace; i++)
        {
            items.Add(new Item(null, ObjectName, 3, 3, false, false, true, false, 0, 0));
            //ObjectName = player.ObjectName;
            //if (ObtainedItems[i] == null)
            //{
            //    ObtainedItems[i] = ObjectName;
            //    i = InventorySpace;
            //}
        }
    }

    public void DisplayInventory()
    {
        for (int i = 0; i < InventorySpace; i++)
        {
            //Debug.Log(ObtainedItems[i]);
        }
    }
}
