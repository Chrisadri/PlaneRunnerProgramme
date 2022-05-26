using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadNames : MonoBehaviour//loads player names into next scene
{
    public TextMeshProUGUI displayPlayer1Name;
    public TextMeshProUGUI displayPlayer2Name;

    void Update()
    {
        displayPlayer1Name.text = PlayersNames.playersNames.player1Name;//reffs PlayerNames script for name grab
        displayPlayer2Name.text = PlayersNames.playersNames.player2Name;
    }
}
