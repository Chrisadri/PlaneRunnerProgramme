using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity); //Spawning and positioning the groundTile
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }


    private void Start()
    {
        for (int i = 0; i < 50; i++) //calls the function the number we specify (50)
        {
            SpawnTile();
        }
       

    }

  
}
    