using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // using this to trigure animation, there's already a reff of anim in the CharacterMovement script
    CharacterMovement cm; //refrence to the other script controlling the character
    public GameObject currentWeapon; //reff to current weapon

    PlayerInputs inputs; // reff to the player inputs script for P1 and P2


    
    void Start()
    {
        cm = GetComponent<CharacterMovement>(); //gets the ref script on startup
        inputs = GetComponent<PlayerInputs>(); //getting P1 and P2 inputs on startup
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(inputs.fire)) //sets shoot button to left control
        {
            Shoot();
        }


        //cm.anim.SetBool("Dancing", Input.GetKey(KeyCode.Q)); // this would set a dancing anim or taunt or whatever i want with the Q button
    }

    public void Shoot()
    {
        // cm.anim.SetTrigger("Shoot"); // this is a reff to the anim etc in the other script (CharacterMovement Shoot is the name i've named exactly the same spelling in the animation)
        currentWeapon.GetComponent<IShootable>().Shoot();

    }

}
