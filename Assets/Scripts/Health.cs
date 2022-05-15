using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //so i can add UI for health losing etc

public class Health : MonoBehaviour
{
    // Health values, these will be accessed through other scripts to edit player or enemy health

    [Tooltip("Health Amounts")] //shows in the inspector what this is for
    public int maxHealth, startingHealth, currentHealth; //health possibilities to edit per character/enemy
    public bool canBeDamaged; //can it be damaged

    //components
    public Slider healthUI;


    
    void Start()
    {
        currentHealth = startingHealth; //this only calls on the start
        UpdateHealthUI();
    }

    public virtual void TakeDamage(int amount)
    {
        if (!canBeDamaged)  // if it can't be damaged, don't run the below (return does this function)
        {
            Debug.Log("Attempted to damage " + gameObject.name + " but object can not be damaged right now"); //debug error message to help when things can't be damaged
            return;
        }
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            currentHealth = 0; // sets health to 0 even if it goes below 0 to not look silly
            //call the death function
            TriggerDeath(); // calls death when health is 0
        }

        UpdateHealthUI();

    }
    
    public virtual void TriggerDeath() // this is seperated so first life TriggerDeath can happen whereas death will trigger death anim and next scene
    {
        //animate death, player sound and particles etc (flashing character)
        Debug.Log(gameObject.name + " has been killed");
        canBeDamaged = false;
        Invoke("Die", 2f);
    }

    public virtual void Die()
    {
        Debug.Log(gameObject.name + " removed from scene");
        Destroy(gameObject); //gets rid of game object
    }

    public virtual void UpdateHealthUI()
    {
        if (!healthUI) return;
        healthUI.maxValue = maxHealth; //checks max value is correct
        healthUI.value = currentHealth; //sets the current health to correct value
    }

}
