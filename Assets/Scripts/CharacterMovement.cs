using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [Tooltip("Movement Values")] // tooltip gives a title in the inspector to help remember things
    [SerializeField] float speedMultiplier, belowStage; // allows variables in the inspector without making them public (so you can see them but not change via other scripts)

    //Components
    CharacterController cc; //reference the character controller bc that's what i'm moving
    Animator anim; //animator reffrence

    Vector3 movementDirection; //directions for inputs

    PlayerInputs inputs; // reff to the player inputs script for different buttons for P1 and P2

    
    void Start()
    {
        cc = GetComponent<CharacterController>();
        // anim = GetComponentInChildren<Animator>(); add this when i add animations to the children parts
        inputs = GetComponent<PlayerInputs>(); // getting the component for the P1 and P2 inputs
    }

    // Update is called once per frame
    void Update()
    {
        //these make the inputs from verticle and horizontal assigned to the letters h and v so we can change them for two players
        var h = Input.GetAxis(inputs.horizontal); // gets the inputs horizontal input from PlayerInputs script
        var v = Input.GetAxis(inputs.vertical);

        if (h != 0 || v != 0) //this is so when it's animating, run this block of code
        {
            movementDirection.Set(h, 0, v); // setting x and y axis, the y axis is set to 0 as we're not going up and down
            cc.Move(movementDirection * speedMultiplier * Time.deltaTime); //move method requires a movement to go in, default it moves 1 step in that direction so needs to be multiplied to go faster and smoother
            /* anim.SetBool("HasInput", true); //this sets the animation blend tree of anim NAMES HasInput to true to start animating
        }
        else
        {
            anim.SetBool("HasInput", false); // if it's false, the animtion blend tree will not animate or animate an idle probably */
        }

        /* anim.SetFloat("ForwardMomentum", v); // this is to set the animations for momentum straight that i've named exactly ForwardMomentum
        anim.SetFloat("SideMomentum", h); // this is to set the animations for momentum straight that i've named exactly SideMomentum 
        
        !!!!I THINK BELOW SETS THE ANIMATIONS TO BE FACTING THE CORRECT WAYS, RELATIVE TO WHAT WAY ITS FACING (CHANGING THE ABOVE TWO LINES WHILST ADDING THE ONE BELOW AS WELL)!!!! 
        var animationVector = transform.InverseTransformDirection(cc.velocity);
        
        anim.SetFloat("ForwardMomentum", animationVector.z);
        anim.SetFloat("SideMomentum", animationVector.x);
         */

    }
}
