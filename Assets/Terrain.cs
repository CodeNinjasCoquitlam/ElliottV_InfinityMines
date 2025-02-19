using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{
    float spawnPosX = 62.5f;
    float spawnPosY = 0;
    float spawnPosZ = 62.5f;
    public GameObject stone;
    public GameObject iron;
    public GameObject penut;
    public GameObject gleep;
    public GameObject light_nin;
    public int row;
    public bool startOfGame;
    // Start is called before the first frame update
    void Start()
    {
        
        startOfGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startOfGame)
        {
            StartCoroutine(Wait());
            startOfGame = false;
        }
    }
    public void Reset()
    {
        spawnPosX = 62.5f;
        spawnPosY = 0;
        spawnPosZ = 62.5f;
        GameObject[] can = GameObject.FindGameObjectsWithTag("mineral");
        foreach (var bean in can)
        {
            Destroy(bean); //by consumption, obviously
        }
        Debug.Log("epic!!!");
        StartCoroutine(Wait());

    }
    IEnumerator Wait()
    {


        for (int j = 0; j < 50; j++)
        {

            for (int k = 0; k < 50; k++)
            {
                Instantiate(stone, new Vector3(spawnPosX, spawnPosY, spawnPosZ), Quaternion.identity);
                spawnPosX -= 2.5f;



            }
            spawnPosZ -= 2.5f;
            spawnPosX = 62.5f;
            yield return new WaitForSeconds(0.01f);


        }


        

        spawnPosX = 62.5f;
        spawnPosY = 127.5f;
        spawnPosZ = 62.5f;

        for (int l = 0; l < 50; l++)
        {

            for (int m = 0; m < 50; m++)
            {
                Instantiate(stone, new Vector3(spawnPosX, spawnPosY, spawnPosZ), Quaternion.identity);
                spawnPosX -= 2.5f;

            }
            spawnPosZ -= 2.5f;
            spawnPosX = 62.5f;
            yield return new WaitForSeconds(0.01f);


        }
        spawnPosZ = 62.5f;
        spawnPosX = 62.5f;
    }
  

}