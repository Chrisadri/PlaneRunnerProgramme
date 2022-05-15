using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralAOEDamage : MonoBehaviour
{
    // attatch this script so if something collides into other things like buildings it takes the set amount of damage

    public int damageAmount;

    private void OnTriggerEnter(Collider other) //when a collider hits another collider
    {
        Debug.Log("hit"); //just so i know if it hit or not
        var healthScript = other.GetComponent<Health>(); //gets the health script as a refference
        if (!healthScript)
        {
            Debug.Log("no health script attatched");
            return;
        }

        healthScript.TakeDamage(damageAmount); // how much damage to take if this object is hit
    }

}
