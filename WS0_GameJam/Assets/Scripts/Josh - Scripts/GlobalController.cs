using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    public int testVar = 50;

    public WinScript winchecker;
    public LoseScript losschecker; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
