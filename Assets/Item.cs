using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public Sprite ItemSprite;
    public string ItemName;
    public float ItemWeight;
    public float ItemCost;
    public bool IsEquipable;
    public bool IsQuestItem;
    public bool IsJunk;
    public bool IsConsumable;
    public int MaxUses;
    public int UsesLeft;

    public Item(Sprite ItemSprite, string ItemName, float ItemWeight, float ItemCost, bool IsEquipable, bool IsQuestItem, bool IsJunk, bool IsConsumable, int MaxUses, int UsesLeft)
    {
    }

    // Use this for initialization
    void Start () {
        var objectName = transform.name;

        if (objectName == "Pickup")
        {
            ItemSprite = null;
            ItemName = "Pickup";
            ItemWeight = 1;
            ItemCost = 1;
            IsEquipable = false;
            IsQuestItem = false;
            IsJunk = true;
            IsConsumable = false;
            MaxUses = 0;
            UsesLeft = 0;
        }
        if (objectName == "BoxSmall")
        {
            ItemSprite = null;
            ItemName = "BoxSmall";
            ItemWeight = 4;
            ItemCost = 4;
            IsEquipable = false;
            IsQuestItem = false;
            IsJunk = true;
            IsConsumable = false;
            MaxUses = 0;
            UsesLeft = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
