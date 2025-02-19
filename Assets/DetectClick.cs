using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectClick : MonoBehaviour
{
    public Inventory invi;
    public byte ID;
    public float layer;
    public Camera playerCamera;
    public Canvas Canvas;
    public Player_Cam camScript;
    public GameObject tempTrigger;
    
    public GameObject stone;
    public GameObject iron;
    public GameObject penut;
    public GameObject gleep;
    public GameObject light_nin;
    public GameObject defaultium;
    public GameObject EVIL;
    public GameObject wet;
    public GameObject idiot;
    public GameObject rot;
    public GameObject horse;
    public GameObject crusher;
    public GameObject BEAUTY;
    public GameObject what;
    public GameObject REALcopper;
    public GameObject REALsilver;
    public GameObject REALgold;
    public GameObject oresixteen;

    // Start is called before the first frame update
    void Start()
    //hii
    {
        //setup of prefabs
        stone = Resources.Load<GameObject>("Prefabs/Ston");
        iron = Resources.Load<GameObject>("Prefabs/Iorn");
        penut = Resources.Load<GameObject>("Prefabs/penut");
        gleep = Resources.Load<GameObject>("Prefabs/gleeeeeeeeeeepitis");
        light_nin = Resources.Load<GameObject>("Prefabs/Lightning Essence");
        defaultium = Resources.Load<GameObject>("Prefabs/defaultium");
        EVIL = Resources.Load<GameObject>("Prefabs/EVIL Ston");
        wet = Resources.Load<GameObject>("Prefabs/wet");
        idiot = Resources.Load<GameObject>("Prefabs/samuel");
        rot = Resources.Load<GameObject>("Prefabs/slightly rotated stone");
        horse = Resources.Load<GameObject>("Prefabs/horseore");
        crusher = Resources.Load<GameObject>("Prefabs/crushe");
        BEAUTY = Resources.Load<GameObject>("Prefabs/perfection");
        what = Resources.Load<GameObject>("Prefabs/concerningly realistic stone");
        REALcopper = Resources.Load<GameObject>("Prefabs/copper");
        REALsilver = Resources.Load<GameObject>("Prefabs/silver");
        REALgold = Resources.Load<GameObject>("Prefabs/gold");
        oresixteen = Resources.Load<GameObject>("Prefabs/ore sixteen");

        //setup of non-prefabs
        camScript = GameObject.Find("Main Camera").GetComponent<Player_Cam>();




        GameObject payer = GameObject.Find("Player");
        invi = payer.GetComponent<Inventory>();
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        layer = (gameObject.transform.position.y / 2.5f);
        if(transform.position.y >= 2.5f)
        {
            if (transform.position.x > -62.5f && transform.position.z < 65f)
            {
                if (transform.position.z > -62.5f && transform.position.z < 65f)
                {
                    if(transform.position.y < 127.5f)
                    {
                        Destroy(gameObject);
                    }

                }
            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCamera.ScreenPointToRay(new Vector3 (Screen.width / 2, Screen.height / 2, 0));
            //Debug.DrawRay(playerCamera.gameObject.transform.position, playerCamera.gameObject.transform.forward * 100, Color.red, 100f);
            RaycastHit hit;
            

            if(Physics.Raycast(ray, out hit, 10, LayerMask.GetMask("theground")))
            {
                if(hit.collider.gameObject == gameObject)
                    {
                    if (camScript.isLocked)
                    {
                        invi.AddItem(ID);


                        if (Physics.OverlapSphere(transform.position + new Vector3(0, -2.5f, 0), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(0, -2.5f, 0));
                        }

                        if (Physics.OverlapSphere(transform.position + new Vector3(-2.5f, 0, 0), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(-2.5f, 0, 0));
                        }

                        if (Physics.OverlapSphere(transform.position + new Vector3(0, 2.5f, 0), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(0, 2.5f, 0));
                        }

                        if (Physics.OverlapSphere(transform.position + new Vector3(0, 0, -2.5f), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(0, 0, -2.5f));
                        }

                        if (Physics.OverlapSphere(transform.position + new Vector3(0, 0, 2.5f), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(0, 0, 2.5f));
                        }

                        if (Physics.OverlapSphere(transform.position + new Vector3(2.5f, 0, 0), 1).Length <= 0)
                        {
                            RandomSpawn(new Vector3(2.5f, 0, 0));
                        }


                        tempTrigger = new GameObject("TempBlock");
                        tempTrigger.transform.position = gameObject.transform.position;
                        tempTrigger.tag = "IGNORE";
                        tempTrigger.layer = LayerMask.NameToLayer("Ignore Clicks");
                        Debug.Log("yu hitt" + hit.collider.gameObject.name);
                        Collider triggerCollider = tempTrigger.AddComponent<BoxCollider>();
                        triggerCollider.isTrigger = true;

                        Destroy(hit.collider.gameObject);
                    }
                        
                }
                
            }
            
        }
    }

    void RandomSpawn(Vector3 egg)
    {

        if ((layer * -1) <= -1)
            if (Random.Range(0, 9) == 0)
                Instantiate(rot, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else
                Instantiate(stone, transform.position + egg, new Quaternion(0, 0, 0, 0));


        else if ((layer * -1) <= 10)
        {
            if (Random.Range(0, 2047) == 0)
                Instantiate(gleep, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 149) == 0)
                Instantiate(idiot, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 31) == 0)
                Instantiate(iron, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else
                Instantiate(stone, transform.position + egg, new Quaternion(0, 0, 0, 0));

        } 
        else if((layer * -1) <= 99)
        {
            if (Random.Range(0, 14999) == 0)
                Instantiate(light_nin, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 4999) == 0)
                Instantiate(defaultium, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 127) == 0)
                Instantiate(penut, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 19) == 0)
                Instantiate(iron, transform.position + egg, new Quaternion(0, 0, 0, 0));

            else
                Instantiate(stone, transform.position + egg, new Quaternion(0, 0, 0, 0));
        } else if (layer * -1 == 160)
        {


            Instantiate(oresixteen, transform.position + egg, new Quaternion(0, 0, 0, 0));


        } else if ((layer * -1) <= 199)
        {
            if (Random.Range(0, 499) == 0)
                Instantiate(wet, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 29) == 0)
                Instantiate(iron, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 15) == 0)
                Instantiate(EVIL, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else
                Instantiate(stone, transform.position + egg, new Quaternion(0, 0, 0, 0));
        } else if ((layer * -1) <= 299)
        {
            if (Random.Range(0, 19999999) == 0)
                Instantiate(BEAUTY, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 149999) == 0)
                Instantiate(horse, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 2499) == 0)
                Instantiate(crusher, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 499) == 0)
                Instantiate(REALgold, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 49) == 0)
                Instantiate(REALsilver, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else if (Random.Range(0, 19) == 0)
                Instantiate(crusher, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else
                Instantiate(what, transform.position + egg, new Quaternion(0, 0, 0, 0));
        } else
        {
            if (Random.Range(0, 20) == 0)
                Instantiate(PING, transform.position + egg, new Quaternion(0, 0, 0, 0));
            else
                Instantiate(PING, transform.position + egg, new Quaternion(0, 0, 0, 0));

        }
        
    }




}
