using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health //i've changed monobehaviour so this now inherits all the Health scripts content, new health inherits monobehaviour so i don't need it here
{
    public Image healthUIImage;

    public LoseGame loseGameScript;

    private void Update()
    {
        UpdateHealthUI();

        if (currentHealth <= 0) //if player die call GameLost function in LoseGame script
        {
            TriggerDeath(); // NOT SURE IF THIS IS CORRECT ******************************************************
            Die(); // NOT SURE IF THIS IS CORRECT ******************************************************
            loseGameScript.GameLost();
        }
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        canBeDamaged = false;
        Invoke("ResetDamage", 1);
    }

    public override void TriggerDeath() //this is grabbing from health script, override means to do none of the inherited scripts actions though
    {
        base.TriggerDeath(); // writing base then TriggerDeath function allows the norm scripts inheritence to not be overriden but added with the below
        Animator anim = GetComponentInChildren<Animator>(); //gets animator component in the children with the death anim
        anim.SetBool("Death", true); // exact same name as in animations
    }

    public override void Die()
    {
        Destroy(gameObject);
    }

   /*public override void UpdateHealthUI()
    {
        if (!healthUIImage) return;
        float amount = ((float)currentHealth / (float)maxHealth);
        healthUIImage.fillAmount = amount;
    } */

    public void ResetDamage()
    {
        canBeDamaged = true;
        Debug.Log("can be damaged again");
    }

}
