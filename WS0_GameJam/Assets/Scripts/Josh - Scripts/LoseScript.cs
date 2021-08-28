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

    }

    public void Lose()
    {
        if (1 == 1)
        {
            global.gameEnded = false; // Change to true later
        }
        else
        {
            return;
        }
    }
}
