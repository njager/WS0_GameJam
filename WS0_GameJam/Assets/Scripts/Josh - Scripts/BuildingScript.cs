using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
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
            global.buildingSprite1.SetActive(false);
            global.buildingNewIcon1.SetActive(true);
        }

        if (global.building1Burned == false)
        {
            global.buildingSprite1.SetActive(true);
            global.buildingNewIcon1.SetActive(false);
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
            global.buildingSprite2.SetActive(false);
            global.buildingNewIcon2.SetActive(true);
        }

        if (global.building2Burned == false)
        {
            global.buildingSprite2.SetActive(true);
            global.buildingNewIcon2.SetActive(false);
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
            global.buildingSprite3.SetActive(false);
            global.buildingNewIcon3.SetActive(true);
        }

        if (global.building3Burned == false)
        {
            global.buildingSprite3.SetActive(true);
            global.buildingNewIcon3.SetActive(false);
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
            global.buildingSprite4.SetActive(false);
            global.buildingNewIcon4.SetActive(true);
        }

        if (global.building4Burned == false)
        {
            global.buildingSprite4.SetActive(true);
            global.buildingNewIcon4.SetActive(false);
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
            global.buildingSprite5.SetActive(false);
            global.buildingNewIcon5.SetActive(true);
        }

        if (global.building5Burned == false)
        {
            global.buildingSprite5.SetActive(true);
            global.buildingNewIcon5.SetActive(false);
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
            global.buildingSprite6.SetActive(false);
            global.buildingNewIcon6.SetActive(true);
        }

        if (global.building6Burned == false)
        {
            global.buildingSprite6.SetActive(true);
            global.buildingNewIcon6.SetActive(false);
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
            global.buildingSprite7.SetActive(false);
            global.buildingNewIcon7.SetActive(true);
        }

        if (global.building7Burned == false)
        {
            global.buildingSprite7.SetActive(true);
            global.buildingNewIcon7.SetActive(false);
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
