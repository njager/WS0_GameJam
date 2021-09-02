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
   
    }

    public void Building1BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building2BurnedStatus()
    {
        if(global.building2Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building2Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building3BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building4BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building5BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building6Burned()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building8BurnedStatus()
    {
        if (global.building1Burned == true)
        {
             Debug.Log("Specifically Building1");
             selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
             Debug.Log("Specifically Building1");
             selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
             return;
        }
        
    }

    public void Building9BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Build10BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
            Debug.Log("Specifically Building1");
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }
}
