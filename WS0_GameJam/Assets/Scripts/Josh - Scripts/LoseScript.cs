using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    private GlobalController global;
    void Start()
    {
        global = GlobalController.instance;
    }

    public void LoseChecker()
    {
        if (global.intelligenceStat <= 100f)
        {
            global.gameEnded = true; 
        }
        if (global.publicOpinion >= 0)
        {
            global.gameEnded = true;
        }
    }

    public void Lose()
    {
        if (global.gameEnded == true)
        {
            global.gamePaused = true; // Change to true late
        }
        else
        {
            return;
        }
    }
}
