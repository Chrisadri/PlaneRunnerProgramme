using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity); //Quaternion identity just means no rotation of tiles
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }


    void Start()
    {
        for (int i = 0; i < 3; i++) //calls the function the number we specify (3)
        {
            SpawnTile();
        }
       

    }

  
}
    