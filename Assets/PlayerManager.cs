using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float senseX;
    public float senseY;
    public Transform spinAmount;
    float Xrot;
    float Yrot;
    bool isLocked;
     
    
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (isLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * senseX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * senseY;
            Yrot += mouseX;
            Xrot -= mouseY;
            Xrot = Mathf.Clamp(Xrot, -90f, 90f);
            transform.rotation = Quaternion.Euler(Xrot, Yrot, 0);
            spinAmount.rotation = Quaternion.Euler(0, Yrot, 0);
        } else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }
}
