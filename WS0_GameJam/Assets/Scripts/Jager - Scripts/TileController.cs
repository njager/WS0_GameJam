using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    //member variable
    
    WaitForSeconds delay = new WaitForSeconds(1);

    //public variables
    public int freeTiles;
    public bool isSearching;
    public int opinion;
    public float intel;

    // Start is called before the first frame update
    void Start()
    {
        opinion = 50;
        intel = 0f;
        freeTiles = 4;
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
       
        if (freeTiles > 0)
        {
            freeTiles--;
            yield return null;
        }
        if(freeTiles == 0)
        {
            opinion -= 5;
            yield return null;
        }
        yield return null;
    }
}   
