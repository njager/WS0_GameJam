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

        global.buildingNewIcon1.SetActive(false);
        global.buildingNewIcon2.SetActive(false);
        global.buildingNewIcon3.SetActive(false);
        global.buildingNewIcon4.SetActive(false);
        global.buildingNewIcon5.SetActive(false);
        global.buildingNewIcon6.SetActive(false);
        global.buildingNewIcon7.SetActive(false);
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
            global.buildingButton1.SetActive(false);
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

    public void Building2BurnedStatus() // Book
    {
        if(global.building2Burned == true)
        {
            global.buildingSprite2.SetActive(false);
            global.buildingNewIcon2.SetActive(true);
            global.buildingButton2.SetActive(false);
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

    public void Building3BurnedStatus() // Book
    {
        if (global.building3Burned == true)
        {
            global.buildingSprite3.SetActive(false);
            global.buildingNewIcon3.SetActive(true);
            global.buildingButton3.SetActive(false);
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
            global.buildingButton4.SetActive(false);
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
        if(global.building5Burned == true) // Book
        {
            global.buildingSprite5.SetActive(false);
            global.buildingNewIcon5.SetActive(true);
            global.buildingButton5.SetActive(false);
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
            global.buildingButton6.SetActive(false);
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
            global.buildingButton7.SetActive(false);
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

    public void ChangeburnStatus1() // Bad
    {
        global.opinionStat -= 0.3f;
        global.building1Burned = true;
        global.DeactivateTilebox1();
        global.Camera.TriggerShake(1f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus2() // Good
    {
        global.opinionStat += 0.2f;
        global.booksBurned += 1;
        global.building2Burned = true;
        global.DeactivateTilebox2();
        global.Camera.TriggerShake(0.4f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus3() // Good
    {
        global.opinionStat += 0.2f;
        global.booksBurned += 1;
        global.building3Burned = true;
        global.DeactivateTilebox3();
        global.Camera.TriggerShake(0.4f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus4() // Bad
    {
        global.opinionStat -= 0.3f;
        global.building4Burned = true;
        global.DeactivateTilebox4();
        global.Camera.TriggerShake(1f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus5() // Good
    {
        global.opinionStat += 0.2f;
        global.booksBurned += 1;
        global.building5Burned = true;
        global.DeactivateTilebox5();
        global.Camera.TriggerShake(0.4f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus6() // Bad
    {
        global.opinionStat -= 0.3f;
        global.building6Burned = true;
        global.DeactivateTilebox6();
        global.Camera.TriggerShake(1f);
        global.bookBurningSound.Play();
    }

    public void ChangeburnStatus7() // Bad
    {
        global.opinionStat -= 0.3f;
        global.building7Burned = true;
        global.DeactivateTilebox7();
        global.Camera.TriggerShake(1f);
        global.bookBurningSound.Play();
    }
}
