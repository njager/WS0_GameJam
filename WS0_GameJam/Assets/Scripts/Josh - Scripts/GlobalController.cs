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

    [Header("Stats GameObjects")]
    public GameObject intelligenceMeter;
    public GameObject publicOpinionMeter;

    [Header("Map")]
    public GameObject mapContainer;

    [Header("Jager's Variables")]
    public int freeTiles = 3;
    public bool isSearching;
    public int opinionStat = 50;
    public float intelligenceStat = 0f;
    public GameObject tileBox1;

    public List<GameObject> tileBoxList;

    [Header("Bools")]
    public bool gameEndedWin = false;
    public bool gameEndedLoss = false;
    public bool gamePaused = false;

    [Header("FreeTiles")]
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

    //Private Variables, Jager Creator
    private int tileBoxIndex = 0;
    private GameObject currentTileBox;
    private bool hasBook;
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

        intelligenceStat += 1 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Escape)) // Player Pausing Functionality 
        {
            gamePaused = !gamePaused;
            Debug.Log("Escape");
        }
        PauseGame();

        //check if left mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse clicked!");
            //send out a raycast at mouse location
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            //register raycast hits
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                //if raycast hit a tile, destroy it
                Debug.Log("Something was clicked!");
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Tile")
                {
                    Destroy(hit.collider.gameObject);
                    StartCoroutine(TileBot());
                }
                if (hit.collider.gameObject.tag == "TileBox1")
                {
                    tileBoxIndex = 0;
                    currentTileBox = tileBoxList[tileBoxIndex];
                    currentTileBox.SetActive(true);
                }
                if (hit.collider.gameObject.tag == "Leave")
                {
                    currentTileBox.SetActive(false);
                }
                if (hit.collider.gameObject.tag == "Burn")
                {
                    Debug.Log("You burned the building!");
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
            }

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
}