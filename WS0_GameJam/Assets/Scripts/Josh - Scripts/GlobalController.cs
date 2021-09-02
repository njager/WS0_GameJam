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
    
    [Header("Numeric Variables")]
    public int opinionStat = 50;
    public float intelligenceStat = 0f;
    public int freeTileCount;


    [Header("Music")]

    public AudioSource backgroundMusic;
    public AudioSource suspenseMusic;

    [Header("Sound Effects")]
    public AudioSource cardFlip;
    public AudioSource buttonPress; 
    public AudioSource angryMobPublicOpinion;
    public AudioSource bookUncovered;
    public AudioSource bookBurningSound;
    public AudioSource winSound;
    public AudioSource loseSound; 

    [Header("Canvases")]
    public GameObject UICanvas;
    public GameObject loseCanvas;
    public GameObject winCanvas;
    public GameObject menuCanvas;
    public GameObject dialogueCanvas;
    public GameObject transparentCanvas;

    [Header("Cameras")]
    public GameObject mapCamera;
    public GameObject otherCamera;

    [Header("The Stats GameObjects")]
    public GameObject intelligenceMeter;
    public GameObject publicOpinionMeter;

    [Header("Map")]
    public GameObject mapContainer;

    [Header("TileBoxes")]
    public GameObject tileBox1;
    public GameObject tileBox2;
    public GameObject tileBox3;
    public GameObject tileBox4;
    public GameObject tileBox5;
    public GameObject tileBox6;
    public GameObject tileBox7;
    public GameObject tileBox8;
    public GameObject tileBox9;
    public GameObject tileBox10; 

    public GameObject currentTileBox; 


    [Header("Bools")]
    public bool gameEndedWin = false;
    public bool gameEndedLoss = false;
    public bool gamePaused = false;
    public bool isBurned = false; 
    public bool hasBook = false; 

    [Header("FreeTiles")]
    public int freeTiles = 3;
    public GameObject freeTileUI;
    public GameObject freeTile1;
    public GameObject freeTile2;
    public GameObject freeTile3;

    [Header("TextBoxes")]
    public GameObject textBox1;
    public GameObject textBox2;
    public int textCounter;

    [Header("Character")]
    public GameObject characterUI;

    [Header("Script References")]
    public BuildingSelector buildingSelector;
 
    WaitForSeconds delay = new WaitForSeconds(1);

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
        DeactivateTilebox();

        gameEndedWin = false; // In case of restart or other shenaningans, stating base values.
        gameEndedLoss = false;
        gamePaused = true;
        Time.timeScale = 1f;
        opinionStat = 50;
        intelligenceStat = 0f;
        freeTiles = 3;
        freeTileCount = 3;
        textCounter = 0;

        UICanvas.SetActive(false); // True starting conditons 
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        tileBox1.SetActive(false);


        otherCamera.SetActive(false);
        mapCamera.SetActive(true);
    }

    void Update()
    {
        winChecker.WinChecker();  // Checks if the player won
        lossChecker.LoseChecker(); // Checks if the player lost

        intelligenceStat += 1 * Time.deltaTime; // Intelligence Meter Stat change

        if (Input.GetKeyDown(KeyCode.Escape)) // Player Pausing Functionality 
        {
            gamePaused = !gamePaused;
            Debug.Log("Escape");
        }
        PauseGame();

        if (freeTileCount == 3)
        {
            freeTile1.SetActive(true);
            freeTile2.SetActive(true);
            freeTile3.SetActive(true);
        }
        if (freeTileCount == 2)
        {
            freeTile1.SetActive(false);
            freeTile2.SetActive(true);
            freeTile3.SetActive(true);
        }
        if (freeTileCount == 1)
        {
            freeTile1.SetActive(false);
            freeTile2.SetActive(false);
            freeTile3.SetActive(true);
        }

       

        //debug to check current intel and opinion in console, made by Jager
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Intelligence = " + intelligenceStat + " Opinion = " + opinionStat);
        }
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

    IEnumerator TileBot() // Made by Jager 
    {
        //if there's free tiles left, reduce the number and nothing else
        if (freeTiles > 0)
        {
            freeTiles--;
            yield return null;
        }
        //if there's no more free tiles, reduce public opinion every tile
        if (freeTiles == 0)
        {
            opinionStat -= 5;
            yield return null;
        }
        yield return null;
    }

    public void TextBoxForwards()
    {
        textCounter++;
        TextChanger();
    }

    public void TextBoxBackwards()
    {
        textCounter--;
        TextChanger();
    }

    IEnumerator TextChanger()
    {
        if (textCounter == 1)
        {
            textBox1.SetActive(true);
            yield return null;
        }
        if (textCounter == 2)
        {
            textBox1.SetActive(false);
            yield return null;
        }
        else
        {
            yield return null;
        }

    }

    public void ActivateTilebox()
    { 
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox1.SetActive(true);
        freeTileUI.SetActive(true);
        characterUI.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void DeactivateTilebox()
    {
        mapContainer.SetActive(true);
        transparentCanvas.SetActive(false);
        tileBox1.SetActive(false);
        freeTileUI.SetActive(false);
        characterUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void BurnBuildingButton()
    {
        if (hasBook == true)
        {
            opinionStat += 25;
            intelligenceStat -= 50;
        }
        if (hasBook == false)
        {
            opinionStat -= 25;
        }
        currentTileBox.SetActive(false);
    }

    public void LeaveBuilding()
    {
        currentTileBox.SetActive(false);
    }

    public void TileClicked()
    {
        Destroy(gameObject);
        StartCoroutine(TileBot());
    }
}