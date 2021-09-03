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
    public GameObject mapButtons;
    public GameObject menuContainer; 

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

    [Header("BurnNLeaveUIs")]

    public GameObject burnNLeave1;
    public GameObject burnNLeave2;
    public GameObject burnNLeave3;
    public GameObject burnNLeave4;
    public GameObject burnNLeave5;
    public GameObject burnNLeave6;
    public GameObject burnNLeave7;

    [Header("Dialogue Frames")]

    public GameObject dialogueFrame1;
    public GameObject dialogueFrame2;
    public GameObject dialogueFrame3;
    public GameObject dialogueFrame4;
    public GameObject dialogueFrame5;
    public GameObject dialogueFrame6;
    public GameObject dialogueFrame7;

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
    } */

    //Doesn't feelsmart, but easiest way to do for multiple unity buttons 
    public void ActivateTilebox1()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave1.SetActive(true);
        dialogueFrame1.SetActive(true);
    }

    public void ActivateTilebox2()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave2.SetActive(true);
        dialogueFrame2.SetActive(true);
    }

    public void ActivateTilebox3()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave3.SetActive(true);
        dialogueFrame3.SetActive(true);
    }

    public void ActivateTilebox4()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave4.SetActive(true);
        dialogueFrame4.SetActive(true);
    }

    public void ActivateTilebox5()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave5.SetActive(true);
        dialogueFrame5.SetActive(true);
    }
    public void ActivateTilebox6()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave6.SetActive(true);
        dialogueFrame6.SetActive(true);
    }

    public void ActivateTilebox7()
    {
        menuContainer.SetActive(true);
        mapButtons.SetActive(true);
        transparentCanvas.SetActive(true);
        characterFile1.SetActive(true);
        freeTileUI.SetActive(true);
        burnNLeave7.SetActive(true);
        dialogueFrame7.SetActive(true);
    }

    //Same for deactivation 
    public void DeactivateTilebox1()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile1.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave1.SetActive(false);
        dialogueFrame1.SetActive(false);
    }

    public void DeactivateTilebox2()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile2.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave2.SetActive(false);
        dialogueFrame2.SetActive(false);
    }

    public void DeactivateTilebox3()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile3.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave3.SetActive(false);
        dialogueFrame3.SetActive(false);
    }

    public void DeactivateTilebox4()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile4.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave4.SetActive(false);
        dialogueFrame4.SetActive(false);
    }

    public void DeactivateTilebox5()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile5.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave5.SetActive(false);
        dialogueFrame5.SetActive(false);
    }

    public void DeactivateTilebox6()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile6.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave6.SetActive(false);
        dialogueFrame6.SetActive(false);
    }

    public void DeactivateTilebox7()
    {
        menuContainer.SetActive(false);
        transparentCanvas.SetActive(false);
        characterFile7.SetActive(false);
        freeTileUI.SetActive(false);
        burnNLeave7.SetActive(false);
        dialogueFrame7.SetActive(false);
    }

}