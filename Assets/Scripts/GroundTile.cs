using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner; //reff to GroundSpawner script

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>(); //returns groundspawner
    }

    private void OnTriggerExit(Collider other) //when something exits the trigger this happens
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2); //destroys the object (ground tile) 2 second after leaving the trigger collider on the inspector: MAY HAVE TO CHANGE COLLIDER SIZE
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
