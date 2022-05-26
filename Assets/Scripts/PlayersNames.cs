using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersNames : MonoBehaviour
{

    public static PlayersNames playersNames;
    public TMPro.TMP_InputField name1;// TMP input name field
    public TMPro.TMP_InputField name2;// TMP input name field

    public string player1Name = "";//stores string for player ones name for loading in after
    public string player2Name = "";//stores string for player twos name for loading in after

    private void Awake()
    {
        if (playersNames == null)//keeps the players names as set
        {
            playersNames = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SavePlayer1Name()
    {
        player1Name = name1.text;//reffs the TMP input above to the correct player1Name
        Debug.Log("player 1: " + player1Name);
    }
    public void SavePlayer2Name()
    {
        player2Name = name2.text;//reffs the TMP input above to the correct player2Name
        Debug.Log("player 2: " + player2Name);
    }

    public void CancelPlayer1Name()//gets rid of the player name TMP value (if you don't want one)
    {
        name1.text = player1Name;
    }

    public void CancelPlayer2Name()//gets rid of the player name TMP value (if you don't want one)
    {
        name2.text = player2Name;
    }
}
