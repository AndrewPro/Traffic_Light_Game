using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Making array in Unity Engine for Cars variant
    public GameObject[] carPrefabs;

    private float startDelay = 2;
    private float spawnInterval= 1;

    //Range time between 3 sec and 7 sec for spawn a car
    private float spawnTimeMin = 5;
    public float spawnTimeMax = 10;

    //
    private float xPos = -4.17f;
    private float yPos = 2.51f;
    private float zPos = -56.7f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomCars", startDelay, Random.Range(spawnTimeMin, spawnTimeMax));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawnRandomCars()
    {
        int carIndex = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(xPos, yPos, zPos);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
