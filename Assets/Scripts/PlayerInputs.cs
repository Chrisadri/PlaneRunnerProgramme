using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{

    public int playerNum = 1; //starts as default 1 but changable
    [HideInInspector] // doesn't allow changes to public values
    public KeyCode fire;
    [HideInInspector]
    public string horizontal, vertical;


    private void Awake()
    {
        DetermineInputs();
    }


    public void DetermineInputs()
    {
        switch (playerNum) //switch runs different code depending on whats in the brackets
        {
            case 1: //if playerNum is 1 (case 1), this happens
                vertical = "P1Vertical";
                horizontal = "P1Horizontal";
               fire = KeyCode.E;
                // reload = KeyCode.Q;                
                break;
            case 2: //player 2
                vertical = "P2Vertical";
                horizontal = "P2Horizontal";
              fire = KeyCode.Keypad0;
              // reload = KeyCode.RightControl;
                break;
        }
    }


}
