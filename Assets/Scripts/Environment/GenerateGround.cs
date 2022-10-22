using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGround : MonoBehaviour
{
    public GameObject[] ground;
    public int z = 100;
    public bool creatingGround = false;
    public int gID;


    void Update()
    {
        if(creatingGround == false)
        {
            creatingGround = true;
            StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        gID = Random.Range(0,3);
        Instantiate(ground[gID], new Vector3(0,14.7f,z), Quaternion.identity);
        z += 100;
        yield return new WaitForSeconds(2);
        creatingGround = false; 
    }
}
