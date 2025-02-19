using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageUnrenderer : MonoBehaviour
{
    public Inventory invi;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(invi.InventoryIDs.IndexOf(id) < 0)
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);

        } else
        {
            gameObject.transform.localScale = new Vector3(1, 1, 0);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
