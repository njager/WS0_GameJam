using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called last every frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse clicked!");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Something was clicked!");
                Debug.Log(hit.collider.gameObject.name);
                if(hit.collider.gameObject.tag == "Tile")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}   
