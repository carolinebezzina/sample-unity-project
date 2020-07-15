using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject Dialogue;
    Text DialogueText;
    private int ObjectLayer;
    public GameObject Object;
    public string ObjectName;
    public string ObjectTest;
    public Inventory inventory;

    void Start()
    {
        Dialogue = GameObject.Find("Dialogue");
        DialogueText = Dialogue.GetComponent<Text>();
        ObjectLayer = LayerMask.NameToLayer("ItemPickup");
        inventory = GetComponentInChildren<Inventory>();
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2))
        {
            if (hit.transform.gameObject.layer == ObjectLayer)
            {
                Object = hit.collider.gameObject;
                ObjectName = Object.GetComponent<Item>().ItemName.ToString();
                DialogueText.text = "Press 'E' to interact with " + ObjectName;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(Object);
                    inventory.AddToInventory();
                }
            }
        }
        else
        {
            DialogueText.text = "";
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventory.DisplayInventory();
        }
    }
}