using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
    private GlobalController global;
    private Renderer selfRenderer;
    public BuildingScript selfReference;
    public Material originalColor; 
    public Material differentColor; 

    void Start()
    {
        global = GlobalController.instance;

        //Grabbing Renderer to change color
        selfRenderer = gameObject.GetComponent<Renderer>();
        //Trying to grab tag 
        GlobalController.instance.building = selfReference; 
    }

    
    void Update()
    {
        if (selfReference.tag == "Building1")
        {
            if (global.isBurned == true)
            {
                Debug.Log("Specifically Building1");
                selfRenderer.material = differentColor;
            }

            if (global.isBurned == false)
            {
                Debug.Log("Specifically Building1");
                selfRenderer.material = originalColor;
            }

            if (global.opinionStat == 15)
            {
                return;
            }
        }

        if (selfReference.tag == "Building2")
        {
            if (global.isBurned == true)
            {
                Debug.Log("Specifically Building2");
                selfRenderer.material = differentColor;
            }

            if (global.isBurned == false)
            {
                Debug.Log("Specifically Building2");
                selfRenderer.material = originalColor;
            }

            if (global.opinionStat == 15)
            {
                return;
            }
        }
        
        if (selfReference.tag == "Building3")
        {
            if (global.isBurned == true)
            {
                selfRenderer.material = differentColor;
            }

            if (global.isBurned == false)
            {
                selfRenderer.material = originalColor;
            }

            if (global.opinionStat == 15)
            {
                return;
            }
        }

        if (selfReference.tag == "Building4")
        {
            if (global.isBurned == true)
            {
                selfRenderer.material = differentColor;
            }

            if (global.isBurned == false)
            {
                selfRenderer.material = originalColor;
            }

            if (global.opinionStat == 15)
            {
                return;
            }
        }
    }
}
