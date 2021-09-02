using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    //member variable
    private int tileBoxIndex = 0;
    private GameObject currentTileBox;
    private bool hasBook;
    private int freeTiles1;
    private int freeTiles2;

    WaitForSeconds delay = new WaitForSeconds(1);

    //public variables
    public int freeTiles;
    public bool isSearching;
    public int opinion;
    public float intel;
    public List<GameObject> tileBoxList;

    // Start is called before the first frame update
    void Start()
    {
        opinion = 50;
        intel = 0f;
        freeTiles = 4;
        freeTiles1 = 4;
        freeTiles2 = 4;
    }

    // Update is called last every frame
    void Update()
    {
        intel += 1 * Time.deltaTime;
        
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
                if(hit.collider.gameObject.tag == "Tile")
                {
                    Destroy(hit.collider.gameObject);
                    StartCoroutine(TileBot());
                }
                if (hit.collider.gameObject.tag == "Tile2")
                {
                    Destroy(hit.collider.gameObject);
                    StartCoroutine(TileBot2());
                }
                else if(hit.collider.gameObject.tag == "TileBox1")
                {
                    tileBoxIndex = 0;
                    currentTileBox = tileBoxList[tileBoxIndex];
                    currentTileBox.SetActive(true);
                }
                else if(hit.collider.gameObject.tag == "TileBox2")
                {
                    tileBoxIndex = 1;
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
                    /*if (hasBook == true)
                    {
                        opinion += 25;
                        intel -= 50;
                    }
                    if (hasBook == false)
                    {
                        opinion -= 25;
                    }*/
                    currentTileBox.SetActive(false);
                    if(tileBoxIndex == 0)
                    {
                        opinion += 25;
                        intel -= 50;
                    }
                    if (tileBoxIndex == 1)
                    {
                        opinion -= 25;
                    }

                }
            }
           
        }

        //debug to check current intel and opinion in console
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("Intelligence = " + intel + " Opinion = " + opinion);
        }
    }

    IEnumerator TileBot()
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
            opinion -= 5;
            yield return null;
        }
        yield return null;
    }
    //coroutine for tiles once clicked
    IEnumerator TileBot1()
    {
        //if there's free tiles left, reduce the number and nothing else
        if (freeTiles1 > 0)
        {
            freeTiles--;
            yield return null;
        }
        //if there's no more free tiles, reduce public opinion every tile
        if(freeTiles1 == 0)
        {
            opinion -= 5;
            yield return null;
        }
        yield return null;
    }
    //coroutine for tiles once clicked
    IEnumerator TileBot2()
    {
        //if there's free tiles left, reduce the number and nothing else
        if (freeTiles2 > 0)
        {
            freeTiles2--;
            yield return null;
        }
        //if there's no more free tiles, reduce public opinion every tile
        if (freeTiles2 == 0)
        {
            opinion -= 5;
            yield return null;
        }
        yield return null;
    }
}   
