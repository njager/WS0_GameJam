using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFileScript3 : MonoBehaviour
{
    private GlobalController global;

    [Header("Tile Covers")]
    public GameObject tileCover1;
    public GameObject tileCover2;
    public GameObject tileCover3;
    public GameObject tileCover4;
    public GameObject tileCover5;
    public GameObject tileCover6;
    public GameObject tileCover7;
    public GameObject tileCover8;
    public GameObject tileCover9;

    [Header("Tile Buttons")]
    public GameObject tileButton1;
    public GameObject tileButton2;
    public GameObject tileButton3;
    public GameObject tileButton4;
    public GameObject tileButton5;
    public GameObject tileButton6;
    public GameObject tileButton7;
    public GameObject tileButton8;
    public GameObject tileButton9;


    void Start()
    {
        tileCover1.SetActive(true);
        tileCover2.SetActive(true);
        tileCover3.SetActive(true);
        tileCover4.SetActive(true);
        tileCover5.SetActive(true);
        tileCover6.SetActive(true);
        tileCover7.SetActive(true);
        tileCover8.SetActive(true);
        tileCover9.SetActive(true);

        global = GlobalController.instance;
    }

    
    public void tileFlip1()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover1.SetActive(false);
        tileButton1.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip2()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover2.SetActive(false);
        tileButton2.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip3() //book
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover3.SetActive(false);
        tileButton3.SetActive(false);
        global.bookUncovered.Play();
        global.cardFlip.Play();
    }
    public void tileFlip4()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover4.SetActive(false);
        tileButton4.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip5()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover5.SetActive(false);
        tileButton5.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip6()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover6.SetActive(false);
        tileButton6.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip7()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover7.SetActive(false);
        tileButton7.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip8()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover8.SetActive(false);
        tileButton8.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip9()
    {
        global.freeTiles3--;
        PushingLuck3();
        tileCover9.SetActive(false);
        tileButton9.SetActive(false);
        global.cardFlip.Play();
    }

    public void PushingLuck3()
    {
        if (global.freeTiles3 == -1)
        {
            global.opinionStat -= 0.07f;
        }
        if (global.freeTiles3 == -2)
        {
            global.opinionStat -= 0.07f;
        }
        if (global.freeTiles3 == -3)
        {
            global.opinionStat -= 0.07f;
        }
        if (global.freeTiles3 == -4)
        {
            global.opinionStat -= 0.07f;
        }
        if (global.freeTiles3 == -5)
        {
            global.opinionStat -= 0.07f;
        }
        if (global.freeTiles3 == -6)
        {
            global.opinionStat -= 0.07f;
        }
    }

}
