using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WinScript : MonoBehaviour
{
    private GlobalController global;
    void Start()
    {
        global = GlobalController.instance; 
    }

    public void WinChecker()
    {
        if (global.booksBurned == 3)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void Win()
    {
        if (global.gameEndedWin == true)
        {
            global.gameEndedWin = false; // Change to true later
        }
        else
        {
            return; 
        }
    }

}
