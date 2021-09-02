using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
    private GlobalController global;
    private Renderer selfRenderer;
    public Material originalColor; 
    public Material differentColor; 

    void Start()
    {
        global = GlobalController.instance;

        //Grabbing Renderer to change color
        selfRenderer = gameObject.GetComponent<Renderer>(); 
    }

    
    void Update()
    {
        if (global.isBurned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.isBurned == false)
        {
            selfRenderer.material = originalColor; 
        }
    }
}
