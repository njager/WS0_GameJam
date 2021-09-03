using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFileScript : MonoBehaviour
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

    }
}
