using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager2048 : MonoBehaviour
{

    // https://www.youtube.com/watch?v=KMi4utDJrUo&list=PLWeGoBm1YHViKSkw7Qox9QgFje3PREEVu&index=5 2:12

    [SerializeField] GameObject fillPrefab;
    [SerializeField] Transform[] allCells;

    public static Action<string> slide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        { 
            SpawnFill();
        }

        if(Input.GetKeyDown(KeyCode.W))
        {

        }
        if (Input.GetKeyDown(KeyCode.A))
        {

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

        }
    }

    public void SpawnFill()
    {
        int whichSpawn = UnityEngine.Random.Range(0, allCells.Length);
        if (allCells[whichSpawn].childCount != 0 )
        {
            SpawnFill();
            Debug.Log(allCells[whichSpawn].name + "is already filled");
            return;
        }
        float chance = UnityEngine.Random.Range(0f, 1f);
        Debug.Log(chance);
        if(chance <.2f)
        {
            return;
        }
        else if(chance <.8f)
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(2);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            tempFillComp.FillValueUpdate(2);
        }
        else
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            Debug.Log(4);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            tempFillComp.FillValueUpdate(4);
        }
    }
}
