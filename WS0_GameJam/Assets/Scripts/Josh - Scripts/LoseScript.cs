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
            global.gameEndedLoss = true; 
        }
        if (global.opinionStat >= 0)
        {
            global.gameEndedLoss = true;
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
