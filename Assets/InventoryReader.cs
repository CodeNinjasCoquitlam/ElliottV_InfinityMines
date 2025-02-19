using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryReader : MonoBehaviour
{
    public Inventory invi;
    public int inviID;
    public Text texty;
    // Start is called before the first frame update
    void Start()
    {
        texty = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texty.text = ("x" + invi.InventoryAmounts[(invi.InventoryIDs.IndexOf(inviID))]);

        //for example (having IIDS as 1, 2 and IAS as 1, 2)
        //"x" + invi.InventoryAmounts[(InventoryIDs.IndexOf(inviID))].toString
        //"x" + invi.InventoryAmounts[(InventoryIDs.IndexOf(1))].toString
        //"x" + invi.InventoryAmounts[1].toString
        //"x" + 1.toString
        //"x1"

        if (invi.InventoryIDs.IndexOf(inviID) < 0)
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 0);
        }
    }
}
