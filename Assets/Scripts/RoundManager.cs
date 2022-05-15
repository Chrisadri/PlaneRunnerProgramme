using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //singleton pattern
    public static RoundManager instance;

    


    private void Awake()
    {
        #region Singleton pattern
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        #endregion

        
    }

    //list of players
    public GameObject[] players;
    //list of scores
    public int[] playerScores;
    //list of spawn positions
    public Transform[] spawnPositions;
    //list of scripts for the game manager to reference
    public Transform[] spawnHealthBar;

   
    

    public int maxKills;


    public void Start()
    {
        SetupScene();
        
    }
    //SETUP SCENE
    public void SetupScene()
    {
        for(int i = 1; i < players.Length+1; i++)
        {
            SpawnPlayer(i);
        }
    }

    

    //SPAWN PLAYERS
    //takes in the player, finds a random position from the list and spawns the player in that position
    public void SpawnPlayer(int playerNumber)
    {
        var player = Instantiate(players[playerNumber-1], spawnPositions[playerNumber-1].position, players[playerNumber-1].transform.rotation);// the reason it's player number-1 is bc naturaly player 1 is 0

        var playerInputs = player.GetComponent<PlayerInputs>();
        playerInputs.playerNum = playerNumber;
        playerInputs.DetermineInputs();

        var playerHealth = player.GetComponent<PlayerHealth>(); //the 3 lines here make it so you can't be damaged instantly on respawn
        playerHealth.canBeDamaged = false;
        playerHealth.Invoke("ResetDamage", 2f);

        
    }
    
    

    public void UpdateScore(int playerScoring, int playerKilled)
    {
        if(playerScoring == 0 || playerScoring == playerKilled)
        {
            playerScores[playerKilled - 1]--;
        }
        else
        {
            playerScores[playerScoring - 1]++;
        }
        if(playerScores[playerScoring-1] >= maxKills)
        {
            EndRound(playerScoring);
        }
    }


    public void EndRound(int WinningPlayer)
    {

    }


}
