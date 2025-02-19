using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rend : MonoBehaviour
{
    private MeshRenderer rende;
    // Start is called before the first frame update
    void Start()
    {
        rende = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameVisible()
    {
        rende.enabled = true;
    }

    void OnBecameInvisible()
    {
        rende.enabled = false;
    }
}
