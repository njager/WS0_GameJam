using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    private GlobalController global;
    void Start()
    {
        global = GlobalController.instance; 
    }

    public void WinChecker()
    {
        
    }

    public void Win()
    {
        if (global.gameEnded == true)
        {
            global.gameEnded = false; // Change to true later
        }
        else
        {
            return; 
        }
    }

}
