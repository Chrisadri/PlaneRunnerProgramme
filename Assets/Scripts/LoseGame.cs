using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseGame : MonoBehaviour
{
    float timeSurvived;
    public static LoseGame loseGameScript;
    public float score;//reff to timer scoring system
    public BuildingsSpawner buildingsSpawnerScript;//reff to BuildingsSpawner script


    

    public void GameLost()
    {
        buildingsSpawnerScript.canSpawn = false;//stops buildings spawning after death
        
        SceneManager.LoadScene(0);//loads menu scene
    }

    private void Update()
    {
        timeSurvived = Time.timeSinceLevelLoad;//basic scoring based on time passed/survived

        score = timeSurvived;//holds scoring timer

        if (BestScoreDisplay.bestScore < score)//makes sure to keep display of the best score held
        {
            BestScoreDisplay.bestScore = score;//reffs script "BestScoreDisplay", then uses bestScore
        }
    }
}
