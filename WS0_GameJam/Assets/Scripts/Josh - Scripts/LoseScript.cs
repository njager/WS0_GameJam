using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LoseScript : MonoBehaviour
{
    private GlobalController global;
    void Start()
    {
        global = GlobalController.instance;
    }

    public void LoseChecker()
    {
        if (global.intelligenceStat > 0.99f)
        {
            SceneManager.LoadScene(3);
        }
        if (global.opinionStat < 0.01f)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Lose()
    {
        if (global.gameEndedLoss == true)
        {
            global.gamePaused = true; // Change to true late
        }
        else
        {
            return;
        }
    }
}
