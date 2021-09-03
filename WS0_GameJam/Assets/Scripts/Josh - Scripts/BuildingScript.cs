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
    public GameObject self; 

    void Start()
    {
        global = GlobalController.instance;

        //Grabbing Renderer to change color
        selfRenderer = self.GetComponent<Renderer>();
    }

    
    void Update()
    {
        Building1BurnedStatus();
        Building2BurnedStatus();
        Building3BurnedStatus();
        Building4BurnedStatus();
        Building5BurnedStatus();
        Building6BurnedStatus();
        Building7BurnedStatus();
    }

    public void Building1BurnedStatus()
    {
        if(global.building1Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building1Burned == false)
        {
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
            selfRenderer.material = differentColor;
        }

        if (global.building2Burned == false)
        {
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building3BurnedStatus()
    {
        if (global.building3Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building3Burned == false)
        { 
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building4BurnedStatus()
    {
        if(global.building4Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building4Burned == false)
        {
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building5BurnedStatus()
    {
        if(global.building5Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building5Burned == false)
        {
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void Building6BurnedStatus()
    {
        if(global.building6Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building6Burned == false)
        {
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }
    public void Building7BurnedStatus()
    {
        if (global.building7Burned == true)
        {
            selfRenderer.material = differentColor;
        }

        if (global.building7Burned == false)
        {
            selfRenderer.material = originalColor;
        }

        if (global.opinionStat == 15)
        {
            return;
        }
    }

    public void ChangeburnStatus1()
    {
        global.building1Burned = true;
        global.DeactivateTilebox1();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus2()
    {
        global.building2Burned = true;
        global.DeactivateTilebox2();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus3()
    {
        global.building3Burned = true;
        global.DeactivateTilebox3();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus4()
    {
        global.building4Burned = true;
        global.DeactivateTilebox4();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus5()
    {
        global.building5Burned = true;
        global.DeactivateTilebox5();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus6()
    {
        global.building6Burned = true;
        global.DeactivateTilebox6();
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus7()
    {
        global.building7Burned = true;
        global.DeactivateTilebox7();
        global.bookBurningSound.Play();
    }
}
