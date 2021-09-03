using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFileScript5 : MonoBehaviour
{
    private GlobalController global;

    public GameObject tileCover1;
    public GameObject tileCover2;
    public GameObject tileCover3;
    public GameObject tileCover4;
    public GameObject tileCover5;
    public GameObject tileCover6;
    public GameObject tileCover7;
    public GameObject tileCover8;
    public GameObject tileCover9;


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
        global.freeTiles5--;
        tileCover1.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip2()
    {
        global.freeTiles5--;
        tileCover2.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip3()
    {
        global.freeTiles5--;
        tileCover3.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip4()
    {
        global.freeTiles5--;
        tileCover4.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip5()
    {
        global.freeTiles5--;
        tileCover5.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip6()
    {
        global.freeTiles5--;
        tileCover6.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip7()
    {
        global.freeTiles5--;
        tileCover7.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip8()
    {
        global.freeTiles5--;
        tileCover8.SetActive(false);
        global.cardFlip.Play();
    }
    public void tileFlip9()
    {
        global.freeTiles5--;
        tileCover9.SetActive(false);
        global.cardFlip.Play();
    }



}