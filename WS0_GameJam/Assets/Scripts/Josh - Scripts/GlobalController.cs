using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    public int testVar = 50;

    [Header("Checkers")]
    public WinScript winChecker;
    public LoseScript lossChecker;

    [Header("Audio")]
    public AudioSource testAudio1;
    public AudioSource testAudio2;

    [Header("Canvases")]
    public GameObject UICanvas;
    public GameObject loseCanvas;
    public GameObject winCanvas;

    [Header("Stats")]
    public GameObject intelligenceBar;
    public GameObject publicOpinionBar; 

    public bool gameEnded = false;
    public bool gamePaused = false;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Somehow more than one GlobalController in scene!");
        }

        instance = this;
    }

    void Start()
    {
        gameEnded = false; // In case of restart or other shenaningans, stating base values.
        gamePaused = true;
        Time.timeScale = 1f;

        UICanvas.SetActive(false); // True starting conditons 
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
    }

    void Update()
    {
        winChecker.WinChecker();  // Checks if the player won
        lossChecker.LoseChecker(); // Checks if the player lost

        if (Input.GetKeyDown(KeyCode.Escape)) // Player Pausing Functionality 
        {
            gamePaused = !gamePaused;
        }
        PauseGame(); 
    }

    public void PauseGame()
    {
        if (gamePaused == false)
        {
            Time.timeScale = 1f;
            return;
        }
        if (gamePaused == true)
        {
            Time.timeScale = 0f;
            return; 
        }
    }
}
