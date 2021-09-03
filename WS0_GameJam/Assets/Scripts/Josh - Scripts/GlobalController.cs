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
    public FreeTileChecker tileCheck;

    [Header("Numeric Variables")]
    public float opinionStat = 50f;
    public float intelligenceStat = 0f;

    [Header("UI Meters")]
    [SerializeField] Image oBar; // Public Opinion Meter
    [SerializeField] Image iBar; // Intelligence Bar

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

    [Header("The Stats GameObjects")]

    public GameObject intelligenceMeter;
    public GameObject publicOpinionMeter;

    [Header("Map")]

    public GameObject mapContainer;
    public GameObject menuContainer; 

    [Header("TileBoxes")]

    public GameObject tileBox1;
    public GameObject tileBox2;
    public GameObject tileBox3;
    public GameObject tileBox4;
    public GameObject tileBox5;
    public GameObject tileBox6;
    public GameObject tileBox7;
    //public GameObject tileBox8;
    //public GameObject tileBox9;
    //public GameObject tileBox10; 

    public GameObject currentTileBox; 


    [Header("Bools")]

    public bool gameEndedWin = false;
    public bool gameEndedLoss = false;
    public bool gamePaused = false;
    public bool hasBook = false;
    public bool isBurned = false;

    [Header("BurnedBools")]

    public bool building1Burned = false;
    public bool building2Burned = false;
    public bool building3Burned = false;
    public bool building4Burned = false;
    public bool building5Burned = false;
    public bool building6Burned = false;
    public bool building7Burned = false;
    public bool building8Burned = false;
    public bool building9Burned = false;
    public bool building10Burned = false;

    [Header("FreeTiles")]

    public GameObject freeTileUI;
    public GameObject freeTile1;
    public GameObject freeTile2;
    public GameObject freeTile3;

    [Header("Building Freetiles")]

    public int freeTiles1 = 3;
    public int freeTiles2 = 3;
    public int freeTiles3 = 3;
    public int freeTiles4 = 3;
    public int freeTiles5 = 3;
    public int freeTiles6 = 3;
    public int freeTiles7 = 3;
    public int freeTiles8 = 3;
    public int freeTiles9 = 3;
    public int freeTiles10 = 3;

    [Header("TextBoxes")]

    public GameObject textBox1;
    public GameObject textBox2;
    public int textCounter;

    [Header("Character")]

    public GameObject characterUI;
    public GameObject characterFile1;
    public GameObject characterFile2;
    public GameObject characterFile3;
    public GameObject characterFile4;
    public GameObject characterFile5;
    public GameObject characterFile6;
    public GameObject characterFile7;
    //  public GameObject characterFile8;
    //  public GameObject characterFile9;
    //  public GameObject characterFile10;

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
        DeactivateTilebox1();
        DeactivateTilebox2();
        DeactivateTilebox3();
        DeactivateTilebox4();
        DeactivateTilebox5();
        DeactivateTilebox6();
        DeactivateTilebox7();
       // DeactivateTilebox8();
       // DeactivateTilebox9();
       // DeactivateTilebox10();

        gameEndedWin = false; // In case of restart or other shenaningans, stating base values.
        gameEndedLoss = false;
        gamePaused = true;
        Time.timeScale = 1f;
        opinionStat = 50;
        intelligenceStat = 0f;
        freeTiles1 = 3;

        freeTiles2 = 3;
        freeTiles3 = 3;
        freeTiles4 = 3;
        freeTiles5 = 3;
        freeTiles6 = 3;
        freeTiles7 = 3;
        freeTiles8 = 3;
        freeTiles9 = 3;
        freeTiles10 = 3;
        textCounter = 0;

        UICanvas.SetActive(false); // True starting conditons 
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
        menuCanvas.SetActive(false);
        mapCamera.SetActive(true);
    }

    void Update()
    {
        winChecker.WinChecker();  // Checks if the player won
        lossChecker.LoseChecker(); // Checks if the player lost

        intelligenceStat += 0.01f * Time.deltaTime; // Intelligence Meter Stat change
        oBar.fillAmount = opinionStat;
        iBar.fillAmount = intelligenceStat;

        if (intelligenceStat < 0f) // Resets the intelligence bar if it were to go below zero 
        {
            intelligenceStat = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // Player Pausing Functionality 
        {
            gamePaused = !gamePaused;
            Debug.Log("Escape");
        }
        PauseGame();

        tileCheck.FreeTileCheck();

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

   /* IEnumerator TileBot() // Made by Jager 
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
    } */

    
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
       // StartCoroutine(TileBot());
    }


    //Doesn't feelsmart, but easiest way to do for multiple unity buttons 
    public void ActivateTilebox1()
    {
        menuContainer.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void ActivateTilebox2()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox2.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile2.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void ActivateTilebox3()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox3.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile3.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void ActivateTilebox4()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox4.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile4.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void ActivateTilebox5()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox5.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile5.SetActive(true);
        dialogueCanvas.SetActive(true);
    }
    public void ActivateTilebox6()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox6.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile6.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    public void ActivateTilebox7()
    {
        mapContainer.SetActive(false);
        transparentCanvas.SetActive(true);
        tileBox7.SetActive(true);
        freeTileUI.SetActive(true);
        characterFile7.SetActive(true);
        dialogueCanvas.SetActive(true);
    }

    //Same for deactivation 
    public void DeactivateTilebox1()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile1.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox2()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile2.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox3()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile3.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox4()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile4.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox5()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile5.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox6()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile6.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateTilebox7()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile7.SetActive(false);
        freeTileUI.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

}