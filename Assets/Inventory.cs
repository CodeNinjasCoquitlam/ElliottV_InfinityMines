using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<int> InventoryAmounts;
    public List<int> InventoryIDs;
    public GameObject inviUI;
    public Player_Cam cam;
    // Start is called before the first frame update
    void Start()
    {
        InventoryAmounts = new List<int>();
        InventoryIDs = new List<int>();
        cam = GameObject.Find("Main Camera").GetComponent<Player_Cam>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (cam.isLocked == true)
            {
                cam.isLocked = false;
                inviUI.SetActive(true);

            } else {

                cam.isLocked = true;
                inviUI.SetActive(false);
            }
        }
    }

    public void AddItem(byte item)
    {
        if (InventoryIDs.Contains(item))
        {
            int location = InventoryIDs.IndexOf(item);
            InventoryAmounts[location]++;
        }
        else
        {
            InventoryIDs.Add(item);
            InventoryAmounts.Add(1);
        }
    }

}
