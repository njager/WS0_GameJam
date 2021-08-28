using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    public int testVar = 50;

    public WinScript winChecker;
    public LoseScript lossChecker;

    [Header("Audio")]
    public AudioSource testAudio1;
    public AudioSource testAudio2;

    [Header("Canvases")]
    public GameObject UICanvas;
    public GameObject loseCanvas;
    public GameObject winCanvas; 

    void Start()
    {
       
    }

    void Update()
    {
        winChecker.WinChecker();  // Checks if the player won
        lossChecker.LoseChecker(); // Checks if the player lost
    }
}
