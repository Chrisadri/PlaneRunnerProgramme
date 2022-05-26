using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour //starts game at scene 1 when play game button is pressed
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene(1);
    }
}