using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    //member variable
    private int freeTiles;


    //public variables
    public bool isSearching;
    public int opinion;
    public float intel;

    // Start is called before the first frame update
    void Start()
    {
        opinion = 50;
        intel = 0f;
        freeTiles = 3;
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
                }
            }
        }
    }

    IEnumerator TileBot()
    {
        while (freeTiles > 0)
        {
            yield return null;
        }
        if(freeTiles < 1)
        {
            opinion -= 5;
        }
        yield return null;
    }
}   
