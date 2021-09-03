using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("Frame 1")]
    public GameObject frame1Log1;
    public GameObject frame1Log2;
    public GameObject frame1Log3;

    [Header("Frame 2")]
    public GameObject frame2Log1;
    public GameObject frame2Log2;
    public GameObject frame2Log3;

    [Header("Frame 3")]
    public GameObject frame3Log1;
    public GameObject frame3Log2;
    public GameObject frame3Log3;

    [Header("Frame 4")]
    public GameObject frame4Log1;
    public GameObject frame4Log2;
    public GameObject frame4Log3;

    [Header("Frame 5")]
    public GameObject frame5Log1;
    public GameObject frame5Log2;
    public GameObject frame5Log3;

    [Header("Frame 6")]
    public GameObject frame6Log1;
    public GameObject frame6Log2;
    public GameObject frame6Log3;

    [Header("Frame 7")]
    public GameObject frame7Log1;
    public GameObject frame7Log2;
    public GameObject frame7Log3;

    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance; 
    }

    void Update()
    {
        DialogueFrameCheck1();
        DialogueFrameCheck2();
        DialogueFrameCheck3();
        DialogueFrameCheck4();
        DialogueFrameCheck5();
        DialogueFrameCheck6();
        DialogueFrameCheck7();
    }

    public void DialogueFrameCheck1()
    {
        if (global.freeTiles1 == 3)
        {

        }
    }

    public void DialogueFrameCheck2()
    {

    }

    public void DialogueFrameCheck3()
    {

    }

    public void DialogueFrameCheck4()
    {

    }

    public void DialogueFrameCheck5()
    {

    }

    public void DialogueFrameCheck6()
    {

    }

    public void DialogueFrameCheck7()
    {

    }
}
