using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Wave//spawn buildings wave reffrence variables script from variable below
{
    public string waveName;//name to reff "forever wave" (i can create diff waves and amounts for diff added levels)
    public int numOfEnemies;//set amount of buildings to come forward (put at max number for now)
    public GameObject[] typeOfEnemies;//list of enemies so i can attatch prefabs i made
    public float spawnSpace;//reff to spawnSpace in SpawnWave() function bellow
}

public class BuildingsSpawner : MonoBehaviour
{
    public Wave[] waves;//reff to above Wave for BuildingSpawner Script now called "Waves" in the inspector, can also add different Waves in set array
    public Transform[] spawnPoints;//keeping spawn points reffrence for buildings prefabs (add diff spawn points to edit spawnPoints in SpawnWave() below)

    private Wave currentWave;// allows namespace for a wave name (forever wave in array set to 1) if i'm to add diff wave styles in the future
    private int currentWaveNum;
    private float nextSpawnTime;

    public bool canSpawn = true;


    private void Update()
    {
        currentWave = waves[currentWaveNum];//stores array number set to store it as current wave (also allowing counting of wanted waves)
        SpawnWave();
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)//spawns prefabs at normal time intervals
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];//making sure wave amount isn't complete and type of enemies is within the arrays
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];//reff to spawnPoints above (can add diff ones for diff waves in future)
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);//randomizes out've the two spawn points
            nextSpawnTime = Time.time + currentWave.spawnSpace;//spawn space reff so i could make diff waves have diff spawn points with diff reff
        }
    }
}
